using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Globalization;
using Microsoft.Reporting.WinForms;

namespace EmployeeWorkingReport
{
    public partial class frmMain : Form
    {
        /// <summary>
        /// The reports will take some time to be generated.
        /// </summary>
        public frmMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Setting date and time values of calStart and calEng fields in main Form,
        /// also the userTableAdapter is filled with employees names and surnames.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMain_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'EvidencijaDataSet.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.evidencijaDataSet.Users);
            
            /*
            var today = DateTime.Today;
            var month = new DateTime(today.Year, today.Month, 1);       
            */
            var today = DateTime.Parse("1.1.2011. 0:00:00");
            var month = new DateTime(today.Year, today.Month, 1); 

            var first = month.AddMonths(-1);
            var last = month.AddDays(-1);

            calStart.SelectionStart = first;
            calStart.SelectionEnd = first;
            calEnd.SelectionStart = last;
            calEnd.SelectionEnd = last;
        }

        /// <summary>
        /// Event for generating report with all employees in list.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbtnAll_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton k = sender as RadioButton;
        }

        /// <summary>
        /// Event for generating report for one chosen employee,
        /// user can choose one employiee from list.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbtnOne_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton r = sender as RadioButton;
            cmbZaposlenik.Enabled = r.Checked;
        }

        /// <summary>
        /// Event is triggered when the starting date is changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void calStart_DateChanged(object sender, DateRangeEventArgs e)
        {
            setDates();
        }

        /// <summary>
        /// Event is triggered when the ending date is changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void calEnd_DateChanged(object sender, DateRangeEventArgs e)
        {
            setDates();
        }

        /// <summary>
        /// When dates are changed in calender form, the fileds lblStart and lblEnd will be updated
        /// </summary>
        private void setDates()
        {
            if (calStart.SelectionStart > calEnd.SelectionStart)
            {
                calEnd.SelectionStart = calStart.SelectionStart;
                calEnd.SelectionEnd = calStart.SelectionStart;
            }

            lblStart.Text = "Starting date: " + calStart.SelectionStart.ToString("dd.MM.yyyy");
            lblEnd.Text = "Ending date: " + calEnd.SelectionStart.ToString("dd.MM.yyyy");
        }

        /// <summary>
        /// When user wannt to list out all employees or for one specific employee this event on button btnWorkingHoursList click will be executed.
        /// Its immportant what values have selected dates and options.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnWorkingHoursList_Click(object sender, EventArgs e)
        {
            DateTime dateStartFilter = Convert.ToDateTime(calStart.SelectionStart.ToString("dd.MM.yyyy"));
            DateTime dateEndFilter = Convert.ToDateTime(calEnd.SelectionStart.ToString("dd.MM.yyyy"));

            int startDate = Convert.ToInt32(calStart.SelectionStart.ToString("yyyyMMdd"));
            int endDate = Convert.ToInt32(calEnd.SelectionStart.ToString("yyyyMMdd"));

            //The data set must be cleaned because of accumulated data
            evidencijaDataSet.WorkDayReport.Clear();
            evidencijaDataSet.DataReport1.Clear();

            //Statement identifiys whatever is selected one or all employees
            if (rbtnAll.Checked)
                this.WorkDayReportTableAdapter.FillByDate(this.evidencijaDataSet.WorkDayReport, startDate, endDate);
            else
                this.WorkDayReportTableAdapter.FillByDateAndUser(this.evidencijaDataSet.WorkDayReport, startDate, endDate, Convert.ToInt32(cmbZaposlenik.SelectedValue));
            
            //Generating data table object
            DataTable dataTable = evidencijaDataSet.WorkDayReport;

            int recordNumbers = dataTable.Rows.Count;
            int dayNumber = (int)(dateEndFilter - dateStartFilter).TotalDays + 1;

            DateTime currentDate = new DateTime();
            int userID = 0;
            string userName = "";
            string date2 = "";
            string day2 = "";

            List<DataRow> newRow = new List<DataRow>();
            int ii = 0;
            int skupina = 0;
            bool monthFinished = true;
            
            //For loop that is filling list with data row objects
            for (int i = 0; i < recordNumbers; i++)
            {
                //Only if all four columns are filled out with data, the new row will bi inserted in list
                if ((ii / dayNumber) % 4 == 0)
                {
                    newRow.Add(evidencijaDataSet.DataReport1.NewRow());
                }

                //becouse the Report2 has four columns we need to develop a sort algorithm by using the dates
                if (userID != Convert.ToInt32(dataTable.Rows[i]["UserID"]) && monthFinished)
                {
                    userID = Convert.ToInt32(dataTable.Rows[i]["UserID"]);
                    userName = dataTable.Rows[i]["LastName"].ToString() + " " + dataTable.Rows[i]["FirstName"].ToString();
                    currentDate = dateStartFilter.Date;
                    monthFinished = false;
                }

                date2 = currentDate.ToString("dd.MM.yyyy");
                day2 = currentDate.ToString("ddd");

                //Translation Datum --> date, DanUMjesecu --> DayInMonth, ZavrsniDatum --> EndDate
                string suffix = ((ii / dayNumber) % 4 == 0 ? "" : (ii / dayNumber) % 4 == 1 ? "2" : (ii / dayNumber) % 4 == 2 ? "3" : (ii / dayNumber) % 4 == 3 ? "4" : "");
                int modGroup = (ii % dayNumber) + (skupina / 4 * dayNumber);
                newRow[modGroup]["UserID" + suffix] = userID;
                newRow[modGroup]["UserName" + suffix] = userName;
                newRow[modGroup]["Datum"] = date2;
                newRow[modGroup]["DanUMjesecu"] = day2;
                newRow[modGroup]["ZavrsniDatum"] = dateEndFilter.ToString("dd.MM.yyyy.");

                //First coulmn will be filled up with dates
                if (currentDate.ToString("yyyyMMdd").Equals(dataTable.Rows[i]["Datum"].ToString()))
                {
                    newRow[modGroup]["WorkStart" + suffix] = dataTable.Rows[i]["WorkSTart"];
                    newRow[modGroup]["WorkEnd" + suffix] = dataTable.Rows[i]["WorkEnd"];
                }
                else
                {
                    //we are staying on the same record until the dates are not equal
                    i--;
                }

                ii++;
                if (ii != 0 && ii % dayNumber == 0)
                    skupina++;

                if (currentDate.ToString("yyyyMMdd").Equals(dateEndFilter.Date.ToString("yyyyMMdd")))
                {
                    monthFinished = true;
                }
                if(currentDate < dateEndFilter)
                currentDate = currentDate.AddDays(1);

            }

            //After the loop has finnish work, all rows from data list are saved in DataReport1 table.
            foreach (DataRow item in newRow)
            {
                evidencijaDataSet.DataReport1.Rows.Add(item);
            }


            int p = evidencijaDataSet.Tables.Count;
            int br = 0;
            String naziv = "DataReport1";
            
            //Finding the right sequence number of the DataReport1 table
            for (br = 0; br < p; br++)
            {
                if (evidencijaDataSet.Tables[br].ToString().Contains(naziv))
                {
                    break;
                }
            }

            ReportDataSource datasource = new ReportDataSource("DataSet1", evidencijaDataSet.Tables[br]);

            //Report2.rdlc loads all defined data from DataReport1 table.
            this.rptvIzvijesce.Reset();
            this.rptvIzvijesce.LocalReport.ReportEmbeddedResource = "EmployeeWorkingReport.Report2.rdlc";
            this.rptvIzvijesce.LocalReport.DataSources.Add(datasource);
            this.rptvIzvijesce.RefreshReport();
        }

        /// <summary>
        /// When user wants to list out all working days for employees this event on button btnWorkingDayList click will be executed.
        /// Its immportant what values have selected dates and options.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnWoringDays_Click(object sender, EventArgs e)
        {
            DateTime dateStartFilter = Convert.ToDateTime(calStart.SelectionStart.ToString("dd.MM.yyyy"));
            DateTime dateEndFilter = Convert.ToDateTime(calEnd.SelectionStart.ToString("dd.MM.yyyy"));

            int startDate = Convert.ToInt32(calStart.SelectionStart.ToString("yyyyMMdd"));
            int endDate = Convert.ToInt32(calEnd.SelectionStart.ToString("yyyyMMdd"));evidencijaDataSet.WorkDayReport.Clear();

            evidencijaDataSet.WorkingDaysReport.Clear();

            //Work day table adapter
            List<DataRow> newDayRow = new List<DataRow>();
            this.usersAndWorkDaysTableAdapter.Fill(this.evidencijaDataSet.UsersAndWorkDays, startDate, endDate);
            

            DataTable dataDayTable = this.evidencijaDataSet.UsersAndWorkDays;
            
            int recordNumber = dataDayTable.Rows.Count;
            int dayNumber = (int)(dateEndFilter - dateStartFilter).TotalDays + 1;
            float rowNumber = dataDayTable.Rows.Count;
            int counter = 1;

            //59 rows can be writhen on one page that has A4 format
            rowNumber = rowNumber / 59;

            if (rowNumber % 1 != 0)
                rowNumber++; //rowNumber is equal 3

            int splitRowNumber = (int)(rowNumber); //3
            int rowGroup = 0;

            if (dataDayTable.Rows.Count >= 59)
                rowGroup = 59;
            else
                rowGroup = dataDayTable.Rows.Count;

            int i = 0;
            //For look fills out List newDayRow with data rows, sort algorithm will add new row if rowGroup number is modulo two.
            for (int q = 0; q < splitRowNumber; q++)
            {           
                if (q % 2 == 0)
                {
                    for (; i < rowGroup; i++)
                    {
                        newDayRow.Add(evidencijaDataSet.WorkingDaysReport.NewRow());
                        newDayRow[i]["UserName"] = dataDayTable.Rows[counter-1]["UserName"].ToString();
                        newDayRow[i]["BrRadnihDana"] = dataDayTable.Rows[counter-1]["Dolasci"].ToString();
                        newDayRow[i]["User_row1"] = counter;
                        newDayRow[i]["PocetniDatum"] = dateStartFilter;
                        newDayRow[i]["ZavrsniDatum"] = dateEndFilter;
                        counter++;
                    }
                    i = rowGroup-59;

                }
                else
                {
                    for (; i < rowGroup; i++)
                    {
                        newDayRow[i]["UserName2"] = dataDayTable.Rows[counter-1]["UserName"].ToString();
                        newDayRow[i]["BrRadnihDana2"] = dataDayTable.Rows[counter-1]["Dolasci"].ToString();
                        newDayRow[i]["User_row2"] = counter;
                        counter++;
                    }

                    i = rowGroup;
                    if (counter + 59 > dataDayTable.Rows.Count)
                        rowGroup = dataDayTable.Rows.Count - rowGroup;
                    else
                        rowGroup = rowGroup+59;
                }
            }
            
            foreach (DataRow item in newDayRow)
            {
                evidencijaDataSet.WorkingDaysReport.Rows.Add(item);
            }
   
            int p = evidencijaDataSet.Tables.Count;
            int br = 0;
            String tableName = "WorkingDaysReport";
            for (br = 0; br < p; br++)
            {
                if(evidencijaDataSet.Tables[br].ToString().Contains(tableName))
                {
                    break;
                }
            }

            //Filling the Reoort4.rdlc with data from WorkingDaysReport table
            ReportDataSource datasource = new ReportDataSource("DataSet1", evidencijaDataSet.Tables[br]);
            this.rptvIzvijesce.Reset();
            this.rptvIzvijesce.LocalReport.ReportEmbeddedResource = "EmployeeWorkingReport.Report4.rdlc";
            this.rptvIzvijesce.LocalReport.DataSources.Add(datasource);
            this.rptvIzvijesce.RefreshReport();
        }


    }
}

namespace EmployeeWorkingReport
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.PodaciReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.evidencijaDataSet = new EmployeeWorkingReport.EvidencijaDataSet();
            this.WorkingDaysReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.WorkDayReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnOne = new System.Windows.Forms.RadioButton();
            this.rbtnAll = new System.Windows.Forms.RadioButton();
            this.cmbZaposlenik = new System.Windows.Forms.ComboBox();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblEnd = new System.Windows.Forms.Label();
            this.calEnd = new System.Windows.Forms.MonthCalendar();
            this.lblStart = new System.Windows.Forms.Label();
            this.calStart = new System.Windows.Forms.MonthCalendar();
            this.btnWorkingHoursList = new System.Windows.Forms.Button();
            this.WorkDayReportTableAdapter = new EmployeeWorkingReport.EvidencijaDataSetTableAdapters.WorkDayReportTableAdapter();
            this.usersTableAdapter = new EmployeeWorkingReport.EvidencijaDataSetTableAdapters.UsersTableAdapter();
            this.DataReport1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnWoringDays = new System.Windows.Forms.Button();
            this.rptvIzvijesce = new Microsoft.Reporting.WinForms.ReportViewer();
            this.usersAndWorkDaysBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersAndWorkDaysTableAdapter = new EmployeeWorkingReport.EvidencijaDataSetTableAdapters.UsersAndWorkDaysTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.PodaciReportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.evidencijaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WorkingDaysReportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WorkDayReportBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataReport1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersAndWorkDaysBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // PodaciReportBindingSource
            // 
            this.PodaciReportBindingSource.DataMember = "DataReport1";
            this.PodaciReportBindingSource.DataSource = this.evidencijaDataSet;
            // 
            // evidencijaDataSet
            // 
            this.evidencijaDataSet.DataSetName = "EvidencijaDataSet";
            this.evidencijaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // WorkingDaysReportBindingSource
            // 
            this.WorkingDaysReportBindingSource.DataMember = "WorkingDaysReport";
            this.WorkingDaysReportBindingSource.DataSource = this.evidencijaDataSet;
            // 
            // WorkDayReportBindingSource
            // 
            this.WorkDayReportBindingSource.DataMember = "WorkDayReport";
            this.WorkDayReportBindingSource.DataSource = this.evidencijaDataSet;
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.SystemColors.Control;
            this.splitter1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.splitter1.MaximumSize = new System.Drawing.Size(500, 0);
            this.splitter1.MinimumSize = new System.Drawing.Size(260, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(260, 691);
            this.splitter1.TabIndex = 2;
            this.splitter1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnOne);
            this.groupBox1.Controls.Add(this.rbtnAll);
            this.groupBox1.Controls.Add(this.cmbZaposlenik);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(232, 122);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choose the employee";
            // 
            // rbtnOne
            // 
            this.rbtnOne.AutoSize = true;
            this.rbtnOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rbtnOne.Location = new System.Drawing.Point(14, 54);
            this.rbtnOne.Name = "rbtnOne";
            this.rbtnOne.Size = new System.Drawing.Size(180, 17);
            this.rbtnOne.TabIndex = 9;
            this.rbtnOne.TabStop = true;
            this.rbtnOne.Text = "Report for one chosen Employee";
            this.rbtnOne.UseVisualStyleBackColor = true;
            this.rbtnOne.CheckedChanged += new System.EventHandler(this.rbtnOne_CheckedChanged);
            // 
            // rbtnAll
            // 
            this.rbtnAll.AutoSize = true;
            this.rbtnAll.Checked = true;
            this.rbtnAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rbtnAll.Location = new System.Drawing.Point(14, 30);
            this.rbtnAll.Name = "rbtnAll";
            this.rbtnAll.Size = new System.Drawing.Size(138, 17);
            this.rbtnAll.TabIndex = 8;
            this.rbtnAll.TabStop = true;
            this.rbtnAll.Text = "Report for all employees";
            this.rbtnAll.UseVisualStyleBackColor = true;
            this.rbtnAll.CheckedChanged += new System.EventHandler(this.rbtnAll_CheckedChanged);
            // 
            // cmbZaposlenik
            // 
            this.cmbZaposlenik.DataSource = this.usersBindingSource;
            this.cmbZaposlenik.DisplayMember = "UserName";
            this.cmbZaposlenik.Enabled = false;
            this.cmbZaposlenik.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cmbZaposlenik.FormattingEnabled = true;
            this.cmbZaposlenik.Location = new System.Drawing.Point(14, 77);
            this.cmbZaposlenik.Name = "cmbZaposlenik";
            this.cmbZaposlenik.Size = new System.Drawing.Size(199, 21);
            this.cmbZaposlenik.TabIndex = 7;
            this.cmbZaposlenik.ValueMember = "ID";
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this.evidencijaDataSet;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblEnd);
            this.groupBox2.Controls.Add(this.calEnd);
            this.groupBox2.Controls.Add(this.lblStart);
            this.groupBox2.Controls.Add(this.calStart);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox2.Location = new System.Drawing.Point(12, 178);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(232, 415);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Select the time range";
            // 
            // lblEnd
            // 
            this.lblEnd.AutoSize = true;
            this.lblEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblEnd.Location = new System.Drawing.Point(12, 224);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(50, 13);
            this.lblEnd.TabIndex = 13;
            this.lblEnd.Text = "End date";
            // 
            // calEnd
            // 
            this.calEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.calEnd.Location = new System.Drawing.Point(14, 246);
            this.calEnd.Name = "calEnd";
            this.calEnd.ShowToday = false;
            this.calEnd.TabIndex = 12;
            this.calEnd.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.calEnd_DateChanged);
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblStart.Location = new System.Drawing.Point(11, 26);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(53, 13);
            this.lblStart.TabIndex = 11;
            this.lblStart.Text = "Start date";
            // 
            // calStart
            // 
            this.calStart.BackColor = System.Drawing.SystemColors.Window;
            this.calStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.calStart.Location = new System.Drawing.Point(14, 48);
            this.calStart.Name = "calStart";
            this.calStart.ShowToday = false;
            this.calStart.TabIndex = 10;
            this.calStart.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.calStart_DateChanged);
            // 
            // btnWorkingHoursList
            // 
            this.btnWorkingHoursList.Location = new System.Drawing.Point(50, 598);
            this.btnWorkingHoursList.Name = "btnWorkingHoursList";
            this.btnWorkingHoursList.Size = new System.Drawing.Size(148, 32);
            this.btnWorkingHoursList.TabIndex = 13;
            this.btnWorkingHoursList.Text = "List of working hours";
            this.btnWorkingHoursList.UseVisualStyleBackColor = true;
            this.btnWorkingHoursList.Click += new System.EventHandler(this.btnWorkingHoursList_Click);
            // 
            // WorkDayReportTableAdapter
            // 
            this.WorkDayReportTableAdapter.ClearBeforeFill = true;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // DataReport1BindingSource
            // 
            this.DataReport1BindingSource.DataMember = "DataReport1";
            this.DataReport1BindingSource.DataSource = this.evidencijaDataSet;
            // 
            // btnWoringDays
            // 
            this.btnWoringDays.Location = new System.Drawing.Point(50, 636);
            this.btnWoringDays.Name = "btnWoringDays";
            this.btnWoringDays.Size = new System.Drawing.Size(148, 30);
            this.btnWoringDays.TabIndex = 15;
            this.btnWoringDays.Text = "List of working days";
            this.btnWoringDays.UseVisualStyleBackColor = true;
            this.btnWoringDays.Click += new System.EventHandler(this.btnWoringDays_Click);
            // 
            // rptvIzvijesce
            // 
            this.rptvIzvijesce.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rptvIzvijesce.LocalReport.ReportEmbeddedResource = "EmployeeWorkingReport.Report2.rdlc";
            this.rptvIzvijesce.Location = new System.Drawing.Point(270, 12);
            this.rptvIzvijesce.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.rptvIzvijesce.Name = "rptvIzvijesce";
            this.rptvIzvijesce.Size = new System.Drawing.Size(802, 581);
            this.rptvIzvijesce.TabIndex = 1;
            // 
            // usersAndWorkDaysBindingSource
            // 
            this.usersAndWorkDaysBindingSource.DataMember = "UsersAndWorkDays";
            this.usersAndWorkDaysBindingSource.DataSource = this.evidencijaDataSet;
            // 
            // usersAndWorkDaysTableAdapter
            // 
            this.usersAndWorkDaysTableAdapter.ClearBeforeFill = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 691);
            this.Controls.Add(this.btnWoringDays);
            this.Controls.Add(this.btnWorkingHoursList);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.rptvIzvijesce);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Evidencija dolazaka";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PodaciReportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.evidencijaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WorkingDaysReportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WorkDayReportBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataReport1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersAndWorkDaysBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnOne;
        private System.Windows.Forms.RadioButton rbtnAll;
        private System.Windows.Forms.ComboBox cmbZaposlenik;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblEnd;
        private System.Windows.Forms.MonthCalendar calEnd;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.MonthCalendar calStart;
        private System.Windows.Forms.Button btnWorkingHoursList;
        private EvidencijaDataSet evidencijaDataSet;
        private System.Windows.Forms.BindingSource WorkDayReportBindingSource;
        private EvidencijaDataSetTableAdapters.WorkDayReportTableAdapter WorkDayReportTableAdapter;
        private System.Windows.Forms.BindingSource PodaciReportBindingSource;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private EvidencijaDataSetTableAdapters.UsersTableAdapter usersTableAdapter;
        private System.Windows.Forms.BindingSource DataReport1BindingSource;
        private System.Windows.Forms.Button btnWoringDays;
        private System.Windows.Forms.BindingSource WorkingDaysReportBindingSource;
        private Microsoft.Reporting.WinForms.ReportViewer rptvIzvijesce;
        private System.Windows.Forms.BindingSource usersAndWorkDaysBindingSource;
        private EvidencijaDataSetTableAdapters.UsersAndWorkDaysTableAdapter usersAndWorkDaysTableAdapter;
    }
}
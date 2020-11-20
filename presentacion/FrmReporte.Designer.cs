namespace presentacion
{
    partial class FrmReporte
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnApplyCustomDate = new System.Windows.Forms.Button();
            this.dateTimePickerToDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerFromDate = new System.Windows.Forms.DateTimePicker();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SalesReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SalesListingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.NetSalesByPeriodBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SalesReportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalesListingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NetSalesByPeriodBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "salesReport";
            reportDataSource1.Value = this.SalesReportBindingSource;
            reportDataSource2.Name = "salesListing";
            reportDataSource2.Value = this.SalesListingBindingSource;
            reportDataSource3.Name = "netSalesByPeriod";
            reportDataSource3.Value = this.NetSalesByPeriodBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "presentacion.Reports.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(200, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(600, 633);
            this.reportViewer1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnApplyCustomDate);
            this.panel1.Controls.Add(this.dateTimePickerToDate);
            this.panel1.Controls.Add(this.dateTimePickerFromDate);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 633);
            this.panel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 394);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Hasta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 359);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Desde";
            // 
            // btnApplyCustomDate
            // 
            this.btnApplyCustomDate.Location = new System.Drawing.Point(22, 426);
            this.btnApplyCustomDate.Name = "btnApplyCustomDate";
            this.btnApplyCustomDate.Size = new System.Drawing.Size(156, 34);
            this.btnApplyCustomDate.TabIndex = 8;
            this.btnApplyCustomDate.Text = "Aplicar";
            this.btnApplyCustomDate.UseVisualStyleBackColor = true;
            this.btnApplyCustomDate.Click += new System.EventHandler(this.btnApplyCustomDate_Click);
            // 
            // dateTimePickerToDate
            // 
            this.dateTimePickerToDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerToDate.Location = new System.Drawing.Point(65, 388);
            this.dateTimePickerToDate.Name = "dateTimePickerToDate";
            this.dateTimePickerToDate.Size = new System.Drawing.Size(114, 20);
            this.dateTimePickerToDate.TabIndex = 7;
            // 
            // dateTimePickerFromDate
            // 
            this.dateTimePickerFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerFromDate.Location = new System.Drawing.Point(65, 353);
            this.dateTimePickerFromDate.Name = "dateTimePickerFromDate";
            this.dateTimePickerFromDate.Size = new System.Drawing.Size(113, 20);
            this.dateTimePickerFromDate.TabIndex = 6;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(22, 299);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(156, 34);
            this.button6.TabIndex = 5;
            this.button6.Text = "Configurar";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(23, 252);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(156, 34);
            this.button5.TabIndex = 4;
            this.button5.Text = "Este año";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(23, 199);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(156, 34);
            this.button4.TabIndex = 3;
            this.button4.Text = "Ultimos 30 dias";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(23, 148);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(156, 34);
            this.button3.TabIndex = 2;
            this.button3.Text = "Este mes";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(23, 96);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(156, 34);
            this.button2.TabIndex = 1;
            this.button2.Text = "7 Dias";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(23, 47);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 34);
            this.button1.TabIndex = 0;
            this.button1.Text = "Hoy";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SalesReportBindingSource
            // 
            this.SalesReportBindingSource.DataSource = typeof(dominio.SalesReport);
            // 
            // SalesListingBindingSource
            // 
            this.SalesListingBindingSource.DataSource = typeof(dominio.SalesListing);
            // 
            // NetSalesByPeriodBindingSource
            // 
            this.NetSalesByPeriodBindingSource.DataSource = typeof(dominio.NetSalesByPeriod);
            // 
            // FrmReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 633);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.panel1);
            this.Name = "FrmReporte";
            this.Text = "Reporte";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SalesReportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalesListingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NetSalesByPeriodBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource SalesReportBindingSource;
        private System.Windows.Forms.BindingSource SalesListingBindingSource;
        private System.Windows.Forms.BindingSource NetSalesByPeriodBindingSource;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button btnApplyCustomDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerToDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerFromDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;

namespace presentacion
{
    public partial class FrmReporte : Form
    {
        public FrmReporte()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
   
        }

        private void getSalesReport(DateTime startDate, DateTime endDate)
        {
            SalesReport reportModel = new SalesReport();
            reportModel.createSalesOrderReport(startDate, endDate);

            SalesReportBindingSource.DataSource = reportModel;
            SalesListingBindingSource.DataSource = reportModel.salesListing;
            NetSalesByPeriodBindingSource.DataSource = reportModel.netSalesByPeriod;

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var fromDate = DateTime.Today; //Fecha actual con cero horas
            var toDate = DateTime.Now; //Ultimas horas con minutos actuales

            getSalesReport(fromDate,toDate);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var fromDate = DateTime.Today.AddDays(-7); //Fecha actual con cero horas
            var toDate = DateTime.Now; //Ultimas horas con minutos actuales

            getSalesReport(fromDate, toDate);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var fromDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1); //Fecha actual con cero horas
            var toDate = DateTime.Now; //Ultimas horas con minutos actuales

            getSalesReport(fromDate, toDate);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var fromDate = DateTime.Today.AddDays(-30); //Fecha actual con cero horas
            var toDate = DateTime.Now; //Ultimas horas con minutos actuales

            getSalesReport(fromDate, toDate);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var fromDate = new DateTime(DateTime.Now.Year, 1, 1); //Fecha actual con cero horas
            var toDate = DateTime.Now; //Ultimas horas con minutos actuales

            getSalesReport(fromDate, toDate);
        }

        private void btnApplyCustomDate_Click(object sender, EventArgs e)
        {
            var fromDate = dateTimePickerFromDate.Value;
            var toDate = dateTimePickerToDate.Value;

            getSalesReport(fromDate, new DateTime(toDate.Year,toDate.Month, toDate.Day,23,59,59));
        }
    }
}

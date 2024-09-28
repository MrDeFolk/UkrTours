using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ukr_TourOp.Ukrainets_tour_opDataSetTableAdapters;

namespace Ukr_TourOp
{
    public partial class Print_form : Form
    {
        public Print_form()
        {
            InitializeComponent();
        }

        private void Print_form_Load(object sender, EventArgs e)
        {
            reportViewer1.LocalReport.ReportEmbeddedResource = "Ukr_TourOp.tour_op.rdlc";
            reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("Print_DataSet", ukrainets_tour_opDataSet1.Tables[0]));

            this.printTableAdapter.Fill(this.ukrainets_tour_opDataSet1.Print);
            this.printTableAdapter.Fill(this.ukrainets_tour_opDataSet1.Print);

            this.reportViewer1.RefreshReport();
            reportViewer1.ShowPrintButton = false;
        }
    }
}

using System;
using Xamarin.Forms;

namespace ERPSolution.MES.Views
{
    public partial class JobListView : ContentPage
    {
        public JobListView()
        {
            InitializeComponent();
        }

        private void ShowJobDetail(object sender, EventArgs e)
        {
            this.Navigation.PushAsync(new JobDetailView());
        }

        private void ScanJobQR(object sender, EventArgs e)
        {
            Navigation.PushAsync(new QRScanView());
        }
    }

    /// <summary>
    /// For test only
    /// </summary>
    public class Task
    {
        public string name { get; set; }

        public string quantity { get; set; }
        
        public string part { get; set; }

        public string deadLine { get; set; }

    }
}

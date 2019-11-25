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

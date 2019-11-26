using Xamarin.Forms;

namespace ERPSolution.MES.Views
{
    public partial class JobDetailView : ContentPage
    {
        public JobDetailView()
        {
            InitializeComponent();
        }
    }

    public class ImplementedEmpoyee
    {
        public string name { get; set; }

        public string quantity { get; set; }

        public string startTime { get; set; }

        public string endTime { get; set; }

        public string note { get; set; }

        public string machine { get; set; }
    }
}

using Xamarin.Forms;

namespace ERPSolution.MES.Views
{
    public partial class MainHomeView : ContentPage
    {
        public MainHomeView()
        {
            InitializeComponent();
        }

        private void ViewJobList(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new JobListView());
        }
    }
}

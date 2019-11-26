using ERPSolution.MES.Helpers;
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

        private async void ScanQRJob(object sender, System.EventArgs e)
        {
            try
            {
                var scanner = DependencyService.Get<IQRScanner>();
                var result = await scanner.ScanAsync();
                if(result != null)
                {
                    await DisplayAlert("Code Result", result, "Cancel");
                }
            }
            catch { }
        }
    }
}

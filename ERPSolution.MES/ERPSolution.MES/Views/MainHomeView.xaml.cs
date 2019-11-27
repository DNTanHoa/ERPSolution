using ERPSolution.MES.Helpers;
using Xamarin.Forms;
using ZXing.Net.Mobile.Forms;

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
            ZXingScannerPage scanner;

            scanner = new ZXingScannerPage();

            await Navigation.PushAsync(scanner);
            scanner.OnScanResult += (result) =>
            {
                Device.BeginInvokeOnMainThread(async () =>
                {
                    await Navigation.PopAsync();
                    await DisplayAlert("Your Code", result.Text, "Cancel");
                });
            };
        }

        private void ShowNotify(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new NotifyListView());
        }

    }
}

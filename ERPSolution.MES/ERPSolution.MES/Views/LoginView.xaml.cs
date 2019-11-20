using Rg.Plugins.Popup.Extensions;
using Rg.Plugins.Popup.Services;
using Xamarin.Forms;

namespace ERPSolution.MES.Views
{
    public partial class LoginView : ContentPage
    {
        public LoginView()
        {
            InitializeComponent();
        }

        private void LoginByFinger(object sender, System.EventArgs e)
        {
            PopupNavigation.Instance.PushAsync(new FingerLoginPopup());
        }
    }
}

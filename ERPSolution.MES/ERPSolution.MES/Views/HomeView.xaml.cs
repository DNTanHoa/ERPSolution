using Xamarin.Forms;

namespace ERPSolution.MES.Views
{
    public partial class HomeView : ContentPage
    {
        public HomeView()
        {
            InitializeComponent();
        }

        private void GotoMainView(object sender, System.EventArgs e)
        {
            this.Navigation.PushAsync(new MainHomeView());
        }
    }

    /// <summary>
    /// For test only
    /// Will be removed when implement logic
    /// </summary>
    public class Employee
    {
        public string displayName { get; set; }

        public string groupName { get; set; }

        public string status { get; set; }

        public bool isActive { get; set; }
    }
}

using Xamarin.Forms;

namespace ERPSolution.MES.Views
{
    public partial class AttandanceView : ContentPage
    {
        public AttandanceView()
        {
            InitializeComponent();
        }

        MasterDetailPage master = new MenuEmployeePersonView();

        private void ShowMenu(object sender, System.EventArgs e)
        {
            
        }
    }
}

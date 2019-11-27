using Xamarin.Forms;

namespace ERPSolution.MES.Views
{
    public partial class NotifyListView : ContentPage
    {
        public NotifyListView()
        {
            InitializeComponent();
        }
    }

    public class NotifyPost
    {
        public string heading { get; set; }

        public string title { get; set; }
        
        public string summary { get; set; }
    }
}

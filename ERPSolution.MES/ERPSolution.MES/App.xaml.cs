using Prism;
using Prism.Ioc;
using ERPSolution.MES.ViewModels;
using ERPSolution.MES.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace ERPSolution.MES
{
    public partial class App
    {
        /* 
         * The Xamarin Forms XAML Previewer in Visual Studio uses System.Activator.CreateInstance.
         * This imposes a limitation in which the App class must have a default constructor. 
         * App(IPlatformInitializer initializer = null) cannot be handled by the Activator.
         */
        public App() : this(null) { }

        public App(IPlatformInitializer initializer) : base(initializer) { }

        protected override async void OnInitialized()
        {
            InitializeComponent();
            //await NavigationService.NavigateAsync("NavigationPage/LoginView");
            await NavigationService.NavigateAsync("MenuEmployeePersonView/NavigationPage/AttandanceView");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<LoginView, LoginViewViewModel>();
            containerRegistry.RegisterForNavigation<FingerLoginPopup, FingerLoginPopupViewModel>();
            containerRegistry.RegisterForNavigation<HomeView, HomeViewViewModel>();
            containerRegistry.RegisterForNavigation<MainView, MainViewViewModel>();
            containerRegistry.RegisterForNavigation<MainHomeView, MainHomeViewViewModel>();
            containerRegistry.RegisterForNavigation<JobListView, JobListViewViewModel>();
            containerRegistry.RegisterForNavigation<JobDetailView, JobDetailViewViewModel>();
            containerRegistry.RegisterForNavigation<NotifyListView, NotifyListViewViewModel>();
            containerRegistry.RegisterForNavigation<QRScanView, QRScanViewViewModel>();
            containerRegistry.RegisterForNavigation<EmployeeInforView, EmployeeInforViewViewModel>();
            containerRegistry.RegisterForNavigation<AttandanceView, AttandanceViewViewModel>();
            containerRegistry.RegisterForNavigation<TaskPauseView, TaskPauseViewViewModel>();
            containerRegistry.RegisterForNavigation<TaskAddView, TaskAddViewViewModel>();
            containerRegistry.RegisterForNavigation<EmployeePaperView, EmployeePaperViewViewModel>();
            containerRegistry.RegisterForNavigation<MenuEmployeePersonView, MenuEmployeePersonViewViewModel>();
        }
    }
}

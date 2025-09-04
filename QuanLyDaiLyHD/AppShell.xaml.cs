using QuanLyDaiLyHD.Views.DaiLyViews;

namespace QuanLyDaiLyHD
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute("ThemDaiLyWindow", typeof(ThemDaiLyWindow));
        }
    }
}
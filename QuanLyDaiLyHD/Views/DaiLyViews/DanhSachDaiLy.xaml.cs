using QuanLyDaiLyHD.ViewModels.DaiLyViewModels;

namespace QuanLyDaiLyHD.Views.DaiLyViews;

public partial class DanhSachDaiLyPage : ContentPage
{
    public DanhSachDaiLyPage(DanhSachDaiLyPageViewModel vm)
    {
        InitializeComponent();
        BindingContext = vm;
    }
}
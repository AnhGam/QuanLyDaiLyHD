using CommunityToolkit.Maui.Views;
using QuanLyDaiLyHD.ViewModels.DaiLyViewModels;

namespace QuanLyDaiLyHD.Views.DaiLyViews;

public partial class ThemDaiLyWindow : Popup
{
    public ThemDaiLyWindow(ThemDaiLyWindowViewModel vm)
    {
        InitializeComponent();
        BindingContext = vm;

        // Pass the popup reference to the ViewModel so it can close itself
        vm.SetPopupReference(this);
    }

}
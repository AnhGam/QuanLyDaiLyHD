using CommunityToolkit.Mvvm.ComponentModel;

namespace QuanLyDaiLyHD.ViewModels;

public partial class BaseViewModel : ObservableObject
{
    [ObservableProperty]
    [NotifyPropertyChangedFor(nameof(IsNotLoading))]
    private bool isLoading = false;

    public bool IsNotLoading => !isLoading;

    [ObservableProperty]
    private string title = string.Empty;
}
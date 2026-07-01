using System.Collections.Generic;
using System.Linq;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using k8s;
using k8s.KubeConfigModels;

namespace KubeControl.App.ViewModels;

public partial class MainViewModel : ViewModelBase
{
    private readonly K8SConfiguration _config;
    
    public MainViewModel()
    {
        _config = KubernetesClientConfiguration.LoadKubeConfig();

        var contexts = _config.Contexts.Select(x => x.Name).ToList();

        Contexts = contexts;
        _currentContext = _config.CurrentContext;
    }
    
    public List<string> Contexts { get; }
    
    [ObservableProperty]
    private string _currentContext;

    [RelayCommand]
    private void SetContext()
    {
        _config.CurrentContext = CurrentContext;
    }
}
using System.Collections.Generic;
using k8s;

namespace KubeControl.App.ViewModels;

public class MainViewModel : ViewModelBase
{
    private readonly KubernetesClientConfiguration _config;
    
    public MainViewModel()
    {
        _config = KubernetesClientConfiguration.BuildConfigFromConfigFile();

        Contexts = [_config.CurrentContext];
    }
    
    public List<string> Contexts { get; }
}
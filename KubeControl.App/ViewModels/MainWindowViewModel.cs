using System.Collections.Generic;
using k8s;

namespace KubeControl.App.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{

    public string Greeting { get; } = "Welcome to Avalonia!";
    
    public List<string> Contexts { get; }
}
using Caliburn.Micro;
using System.Windows;
using WPFwithMVVMDemo.ViewModels;

namespace WPFwithMVVMDemo {
    internal class Bootstrapper : BootstrapperBase {
        public Bootstrapper() {
            Initialize();
        }

        protected override void OnStartup(object sender, StartupEventArgs e) {
            DisplayRootViewForAsync<ShellViewModel>();
        }
    }
}

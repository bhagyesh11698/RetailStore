using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using RetailDesktopUI.ViewModels;
using System.Windows.Controls;
using RetailDesktopUI.Helpers;

namespace RetailDesktopUI
{
    public class Bootstrapper : BootstrapperBase
    {
        public Bootstrapper()
        {
            Initialize();

            ConventionManager.AddElementConvention<PasswordBox>(PasswordBoxHelper.BoundPasswordProperty,"Password","PasswordChanged");

        }

        protected override void OnStartup(object sender, StartupEventArgs e)
        {
            DisplayRootViewForAsync<ShellViewModel>();
            //DisplayRootViewFor<ShellViewModel>();
        }
    }
}

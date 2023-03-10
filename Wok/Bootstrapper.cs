using System.Windows;
using Caliburn.Micro;
using Wok.ViewModels;

namespace Wok
{
	public class Bootstrapper : BootstrapperBase
	{
		public Bootstrapper()
		{
			Initialize();
		}

		protected override void OnStartup(object sender, StartupEventArgs e)
		{
			DisplayRootViewForAsync<DockViewModel>();
		}
	}
}

using Caliburn.Micro;

using System.Windows;

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
			DisplayRootViewFor<DockViewModel>();
		}
	}
}
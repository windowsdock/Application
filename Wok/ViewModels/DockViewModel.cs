using Caliburn.Micro;

namespace Wok.ViewModels
{
	public class DockItems
	{
		public BindableCollection<DockItem> Items;

		public DockItems()
		{
			Items = new BindableCollection<DockItem>();
		}
	}

	public class DockItem
	{
		public DockItem()
		{
		}

		public string Name { get; set; }
	}

	internal class DockViewModel
	{
		private DockItems DockItems = new DockItems();
	}
}
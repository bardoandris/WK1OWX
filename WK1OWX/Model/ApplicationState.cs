namespace WK1OWX.Model
{
	internal class ApplicationState
	{
		public List<Work> WorkOptionList { get; private set; }
		public List<ShopOrder> ShopOrderList { get; private set; }
		private static object _lock = new object();
		private static ApplicationState? instance;
		//This Property might be accessed by multiple threads at the same time
		public static ApplicationState ApplicationStateInstance
		{
			get
			{
				lock (_lock)
				{
					if (instance == null)
					{
						instance = new ApplicationState();
					}
					return instance;
				}
			}
		}
		private ApplicationState()
		{
			WorkOptionList = new();
			ShopOrderList = new();
		}
		public void Reset(List<Work> works)
		{
			WorkOptionList = works;
			ShopOrderList = new();
		}
		public void AddShopOrder(ShopOrder shop)
		{
			ShopOrderList.Add(shop);
		}
	}
}

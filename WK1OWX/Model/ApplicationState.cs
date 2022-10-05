namespace WK1OWX.Model
{
	internal class ApplicationState
	{
		List<Work> WorkOptionList;
		List<ShopOrder> ShopOrderList;
		private static object _lock = new object();
		private static ApplicationState? instance;
		//This Property might be accessed by multiple threads at the same time
		public static ApplicationState GetApplicationState
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
		public void Reset()
		{
			WorkOptionList = new();
			ShopOrderList = new();
		}
	}
}

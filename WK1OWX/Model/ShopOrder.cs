namespace WK1OWX.Model
{
	public class ShopOrder
	{
		List<Work> Items;
		public int TotalTimeCost
		{
			get
			{
				var minutes = (from item in Items
							   select item.Minutes + item.Hours * 60).Sum();
				;
				//Minden fél óra elszámolásra kerül!
				int totalHalfHours =
					(minutes % 30 == 0 ? minutes / 30 : minutes / 30 + 1);


				return totalHalfHours * 7500;

			}
		}
		public int TotalMaterialCost
		{
			get
			{

				return (from item in Items
						select item.MaterialCost).Sum();
			}
		}
		public ShopOrder()
		{
			Items = new List<Work>();
		}
		public void AddItem(Work work)
		{
			Items.Add(work);
			Items = Items.Distinct().ToList();
		}
		public void DeleteItem(Work work)
		{
			Items.Remove(work);
			Items = Items.Distinct().ToList();
		}
	}
}

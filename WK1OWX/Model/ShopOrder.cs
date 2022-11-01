using System.Runtime.CompilerServices;

namespace WK1OWX.Model
{
	public class ShopOrder
	{
		List<Work> Items;
		public int TotalTime_Minutes
		{
			get
			{
				return (from item in Items
						select item.Minutes).Sum();
			}
		}
		public int NumberofWorks { get { return Items.Count; } }
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


				return totalHalfHours * ApplicationState.ApplicationStateInstance.HalfHourCost;

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
		public bool ContainsElement(Work w)
		{
			if (Items.Contains(w))
			{
				return true;
			}
			else return false;
		}
		public ShopOrder()
		{
			Items = new List<Work>();
		}
		private ShopOrder(List<Work> items)
		{
			Items = new List<Work>(items);
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
		public ShopOrder Copy()
		{
			return new ShopOrder(Items);
		}
	}
}

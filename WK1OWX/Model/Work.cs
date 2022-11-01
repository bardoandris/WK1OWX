namespace WK1OWX.Model
{
    public class Work
    {
        private int TotalMinutes { get; }
        public int MaterialCost { get; }
        public string Name { get; }
        public int Minutes { get { return TotalMinutes % 60; } }
        public int Hours { get { return TotalMinutes / 60; } }
        public string DisplayTime
        {
            get
            {
                return $"{(Hours > 0 ? Hours + "ó " : "")}" +
                    $"{(Minutes > 0 ? Minutes + "p" : "")}";
            }
        }
        public string TimeCost
        {
            get
            {
                return (ApplicationState.ApplicationStateInstance.HalfHourCost * ((TotalMinutes / 30) + 1)).ToString();
            }
        }
        public Work(string Name, int minutes, int materialCost)
        {
            this.TotalMinutes = minutes;
            this.MaterialCost = materialCost;
            this.Name = Name;
        }

    }

}

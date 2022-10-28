namespace WK1OWX.Model
{
    public class Work
    {
        private int minutes, materialCost;
        public string Name { get; }
        public int Minutes { get { return minutes % 60; } }
        public int Hours { get { return minutes / 60; } }
        public string DisplayTime
        {
            get
            {
                return $"{(Hours > 0 ? Hours + "ó " : "")}" +
                    $"{(Minutes > 0 ? Minutes + "p" : "")}";
            }
        }
        public string TimeCost { get
            {
                return (ApplicationState.ApplicationStateInstance.HalfHourCost * ((minutes /30) + 1)).ToString();
            } }
        public int MaterialCost { get { return materialCost; } }
        public Work(string Name, int minutes, int materialCost)
        {
            this.minutes = minutes;
            this.materialCost = materialCost;
            this.Name = Name;
        }

    }

}

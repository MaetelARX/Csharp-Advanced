namespace CarSalesman
{
    public class Engine
    {
		private string model;
        private int power;
        private int displacement;
        private string efficiency;

        public Engine (string model, int power, int displacement, string efficiency)
        {
            Model = model;
            Power = power;
            Displacement = displacement;
            Efficiency = efficiency;
        }

        public string Model
		{
			get { return model; }
			set { model = value; }
		}
        public int Power
        {
            get { return power; }
            set { power = value; }
        }
        public int Displacement
        {
            get { return displacement; }
            set { displacement = value; }
        }
        public string Efficiency
        {
            get { return efficiency; }
            set { efficiency = value; }
        }
    }
}

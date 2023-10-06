using System.Text;

namespace CarSalesman
{
    public class Car
    {
        private string model;
        private Engine engine;
        private int weight;
        private string color;

        public Car(string model, Engine engine, int weight, string color)
        {
            Model = model;
            Engine = engine;
            Weight = weight;
            Color = color;
        }

        public string Model
        {
            get { return model; }
            set { model = value; }
        }
        public int Weight
        {
            get { return weight; }
            set { weight = value; }
        }
        public string Color
        {
            get { return color; }
            set { color = value; }
        }
        public Engine Engine
        {
            get { return engine; }
            set { engine = value; }
        }
        public override string ToString()
        {
            StringBuilder text = new StringBuilder();
            text.AppendLine($"{Model}: ");
            text.AppendLine($"  {Engine.Model}:");
            text.AppendLine($"    Power: {Engine.Power}");
            if (Engine.Displacement == default)
            {
                text.AppendLine($"    Displacement: n/a");
            }
            else
            {
                text.AppendLine($"    Displacement: {Engine.Displacement}");
            }
            text.AppendLine($"    Efficiency: {Engine.Efficiency}");
            if (Weight == default)
            {
                text.AppendLine($"  Weight: n/a");
            }
            else
            {
                text.AppendLine($"  Weight: {Weight}");
            }
            text.AppendLine($"  Color: {Color}");

            return text.ToString();
        }
    }
}

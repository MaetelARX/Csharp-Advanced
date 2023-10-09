using System.Text;

namespace _01GenericBoxOfString
{
    public class Box<T>
    {
        List<T> list;

        public Box()
        {
            list = new List<T>();
        }

        public void Add(T items)
        {
            list.Add(items);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            foreach (T item in list)
            {
                sb.AppendLine($"{typeof(T)}: {item}");
            }
            return sb.ToString();
        }
    }
}

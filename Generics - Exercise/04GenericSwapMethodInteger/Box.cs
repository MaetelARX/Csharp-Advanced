using System.Text;

namespace _04GenericSwapMethodInteger
{
    public class Box<T>
    {
        public List<T> list = new List<T>();

        public void Add(T items)
        {
            list.Add(items);
        }
        public void Swap(int firstIndex, int secondIndex)
        {
            (list[secondIndex], list[firstIndex]) = (list[firstIndex], list[secondIndex]);
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

using System.Text;

namespace _06GenericCountMethodDouble
{
    public class Box<T> where T : IComparable<T>
    {
        public List<T> list = new List<T>();

        public void Add(T items)
        {
            list.Add(items);
        }

        public int result(T input)
        {
            int count = 0;

            foreach (T item in list)
            {
                if (item.CompareTo(input) > 0)
                {
                    count++;
                }
            }
            return count;
        }
    }
}

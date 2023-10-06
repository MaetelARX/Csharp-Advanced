namespace BoxOfT
{

    public class Box<T>
    {
        private Stack<T> stack;

        public Box()
        {
            stack = new Stack<T>();
        }
        public void Add(T element)
        {
            stack.Push(element);
        }
        public int Count { get { return stack.Count; } }
        public T Remove()
        {
            return stack.Pop();
        }
    }
}

namespace Structures
{
    public class MyStack<T>
    {
        private readonly List<T> _stack;
        public MyStack()
        {
            _stack = new List<T>();
        }
        public void Push(T element)
        {
            _stack.Add(element);
        }
        public T Pop()
        {
            ThrowIfEmpty();

            var lastElement = _stack.Last();
            _stack.RemoveAt(_stack.Count - 1);
            return lastElement;
        }
        public T Peek()
        {
            ThrowIfEmpty();

            return _stack.Last();
        }
        private void ThrowIfEmpty()
        {
            if (_stack.Count == 0) throw new InvalidOperationException("Stack is Empty");
        }

    }
}

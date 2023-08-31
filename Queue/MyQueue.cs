using Shared;

namespace Queue
{
    public class MyQueue<T>
    { 
        public Node<T>? first;
        public Node<T>? last;

        public MyQueue()
        {
            first = null;
            last = null;
        }

        public void Enqueue(T item)
        {
            Node<T> newNode = new(item);
            if (last != null)
                last.next = newNode;
            else
                last = newNode;

            first ??= last;
        }

        public T Dequeue()
        {
            if (first == null) throw new InvalidOperationException("Queue is empty.");
            T item = first.data;
            first = first?.next;
            if (first == null) last = first;

            return item;
        }

        public Node<T>? Peek()
        {
            if (first == null) throw new InvalidOperationException("Queue is empty.");
            return first;
        }

        public bool IsEmpty() => first == null;
    }
}

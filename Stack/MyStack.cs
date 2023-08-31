namespace Stack
{
    public class MyStack<T>
    {
        public static class Node<T>
        {
            public T data;
            public Node<T> next;
            public Node(T data)
            {
                this.data = data;
            }
            public Node<T> top;

            public T pop<T>()
            {
                if (top == null) throw new InvalidOperationException();
                T item = top.data;
                top = top.next;
                return item;
            }
            public void push<T>(T item)
            {
                Node<T> newNode = new(item);
                newNode.next = top;
                top = newNode;
            }
            public T peek<T>()
            {
                return top.data;
            }
            public bool isEmpty()
            {
                return top == null;
            }

        }
    }
}

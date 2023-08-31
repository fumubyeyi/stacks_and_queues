
using Shared;

namespace Stack
{
    public class MyStack<T>
    {     
        public Node<T>? top;

        public MyStack()
        {
            top = null;
        }

        public T Pop()
        {
            if (top == null) throw new InvalidOperationException("Stack is empty, cannot delete.");
            T item = top.data;
            top = top?.next;
            return item;
        }
        public void Push(T item)
        {
            Node<T> newNode = new(item);
            newNode.next = top;
            top = newNode;
        }
        public Node<T>? Peek()
        {
            return top;
        }
        public bool IsEmpty()
        {
            return top == null;
        }        
    }
}

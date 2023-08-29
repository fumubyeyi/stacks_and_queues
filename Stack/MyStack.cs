namespace Stack;
public class MyStack
{
    public static Node<T>{
        public T data;
        public Node<T> next;

        public Node(T data){
            this.data = data;
        }
        public Node<T> top;

        public T pop(){
            if (top == null) throw new EmptyStackException();
            T item = top.data;
            top = top.next;
            return item;
        }
        public void push(T item){
            Node<T> newNode = new(item);
            newNode.next = top;
            top = newNode;
        }
        public T peek(){
            return top.data;
        }
        public bool isEmpty(){
            return top == null;
        }

    }
}

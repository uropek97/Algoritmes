namespace lesson_3
{
    public class LinkedList<T>
    {
        public Node<T> head;
        

        public class Node<T>
        {
            public T? value;
            public Node<T>? next;

            public Node(T value)
            {
                this.value = value;
            }

            public override string ToString()
            {
                return value!.ToString()!;
            }
        }

        public void Add(T value)
        {
            Node<T> node = new Node<T>(value);
            if(head != null)
                node.next = head;
            head = node;
        }

        public void Revert()
        {
            if(head != null && head.next != null)
            {
                var temp = head;
                Revert(head.next, head);
                temp.next = null;
            }
        }

        private void Revert(Node<T> current, Node<T> prev)
        {
            if (current.next == null)
                head = current;
            else
                Revert(current.next, current);
            current.next = prev;
        }
    }
}

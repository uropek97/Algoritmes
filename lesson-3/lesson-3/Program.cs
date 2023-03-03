namespace lesson_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var list = new LinkedList<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            list.Add(6);
            list.Add(7);
            list.Add(8);
            list.Add(9);
            list.Add(10);

            Console.WriteLine("До: ");
            var a = list.head;
            while(a != null) 
            { 
                Console.Write($"{a.value}  ");
                a = a.next;
            }
            Console.WriteLine();

            list.Revert();

            Console.WriteLine("После: ");
            a = list.head;
            while (a != null)
            {
                Console.Write($"{a.value}  ");
                a = a.next;
            }

            Console.ReadLine();
        }
    }
}
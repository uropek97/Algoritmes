namespace lesson_4
{
    public class Program
    {
        static void Main(string[] args)
        {
            var tree = new RedBlackTree();
            tree.Add(1);
            tree.Add(2);
            tree.Add(3);
            tree.Add(4);
            tree.Add(5);
            tree.Add(6);
            tree.Add(7);
            tree.Add(8);
            Console.WriteLine(tree.root);
            tree.Add(9);               
            tree.Add(10);
            tree.Add(11);              
            tree.Add(12);               
            tree.Add(13);              
            tree.Add(14);               
            tree.Add(15);
            tree.Add(16);
            Console.WriteLine(tree.root);
            tree.Add(17);
            tree.Add(18);
            tree.Add(19);
            tree.Add(20);
            tree.Add(21);
            tree.Add(22);
            tree.Add(23);
            tree.Add(24);
            Console.WriteLine(tree.root);
            

            Console.ReadLine();
        }
    }
}
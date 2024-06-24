using BinaryTree;

namespace Assignment7._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var binaryTree = new BinaryTree<int>();

            binaryTree.Add(8);
            binaryTree.Add(5);
            binaryTree.Add(12);
            binaryTree.Add(27);
            binaryTree.Add(35);
            binaryTree.Add(11);
            binaryTree.Add(22);
            binaryTree.Add(15);
            binaryTree.Add(10);

            foreach (var item in binaryTree)
            {
                Console.WriteLine(item + " ");
            }
            Console.WriteLine();
            Console.WriteLine();
            binaryTree.PrintToConsole();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(binaryTree.Contains(12));
            Console.WriteLine(); Console.WriteLine();
            binaryTree.PrintAsTree();
        }
    }
}

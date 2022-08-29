namespace BinaryTree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Binary serch Tree Add node and search node Program");
            Console.WriteLine("Enter 1 to Create Binary Search Tree");
            int Value = int.Parse(Console.ReadLine());
            BSTOperations<int> bSTOperations = new BSTOperations<int>();

            switch (Value)
            {
                case 1:
                    bSTOperations.AddNode(56);
                    bSTOperations.AddNode(30);
                    bSTOperations.AddNode(70);
                    break;
                default:
                    Console.WriteLine("Make Proper Selection");
                    break;
            }
            
        }
    }
    
}
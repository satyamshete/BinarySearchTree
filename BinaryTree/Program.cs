namespace BinaryTree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Binary serch Tree Add node and search node Program");
            Console.WriteLine("Enter 1 to Create Binary Search Tree");
            Console.WriteLine("Enter 2 to Add elements in Binary Search Tree");
            int Value = int.Parse(Console.ReadLine());
            BSTOperations<int> bSTOperations = new BSTOperations<int>();

            switch (Value)
            {
                case 1:
                    bSTOperations.AddNode(56);
                    bSTOperations.AddNode(30);
                    bSTOperations.AddNode(70);
                    break;
                case 2:
                    bSTOperations.AddNode(56);
                    bSTOperations.AddNode(30);
                    bSTOperations.AddNode(70);
                    bSTOperations.AddNode(22);
                    bSTOperations.AddNode(40);
                    bSTOperations.AddNode(60);
                    bSTOperations.AddNode(95);
                    bSTOperations.AddNode(11);
                    bSTOperations.AddNode(65);
                    bSTOperations.AddNode(3);
                    bSTOperations.AddNode(16);
                    bSTOperations.AddNode(63);
                    bSTOperations.AddNode(67);
                    break;
                default:
                    Console.WriteLine("Make Proper Selection");
                    break;
            }
            
        }
    }
    
}
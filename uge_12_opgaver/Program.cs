namespace uge_12_opgaver
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OrangeTree orangeTree = new OrangeTree();

            orangeTree.Age = 10;
            orangeTree.Height = 100;

            for (int i = 0; i < 10; i++)
            {
                orangeTree.OneYearPasses();
            }
            Console.WriteLine("Ten years has passed!");
           
            Console.WriteLine($"You now have {orangeTree.NumOranges} oranges!");
            Console.ReadLine();
        }
    }
}

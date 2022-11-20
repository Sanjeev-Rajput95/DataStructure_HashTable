namespace HashTable
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("================ WELCOME TO HASHTABLE ========================");

            MyMapNode<int, string> hash = new MyMapNode<int, string>(19);
            hash.Add(0, "Paranoids");
            hash.Add(1, "are");
            hash.Add(2, "not");
            hash.Add(3, "paranoid");
            hash.Add(4, "because");
            hash.Add(5, "they");
            hash.Add(6, "are");
            hash.Add(7, "paranoid");
            hash.Add(8, "but");
            hash.Add(9, "because");
            hash.Add(10, "they");
            hash.Add(11, "keep");
            hash.Add(12, "putting");
            hash.Add(13, "themselves");
            hash.Add(14, "deliberately");
            hash.Add(15, "into");
            hash.Add(16, "paranoid");
            hash.Add(17, "avoidable");
            hash.Add(18, "situations");

            for (int i = 0; i < hash.size; i++)
            {
                Console.WriteLine($"{i} index value : {hash.Get(i)}");
            }

            hash.Remove(14);

            for(int i = 0; i < hash.size; i++)
            {
                Console.WriteLine($"{i} index value : {hash.Get(i)}");
            }
            Console.ReadLine();
        }
    
    }
}
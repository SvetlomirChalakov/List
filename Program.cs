namespace ListCreate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type a LIST of colors> Done to end: ");
            List<string> colorList = new List<string>();
            string input = Console.ReadLine();

            while (input != "Done")
            {
                //mushhhh in colorlist
                colorList.Add(input);
                input = Console.ReadLine();
            }
            colorList[0] = "Pink";

            Console.WriteLine("What element will you delete?(0-" + (colorList.Count - 1) + " ? ");
            int index = int.Parse(Console.ReadLine());

            colorList.RemoveAt(index);



            foreach (string color in colorList)
            {
                Console.WriteLine(color);
            }

        }
    }
}

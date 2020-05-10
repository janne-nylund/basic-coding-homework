using System.IO;
namespace Exercise
{
    public class Program
    {
        public static void Main(string[] args)
        {
            using (StreamWriter writer = new StreamWriter("file.txt"))
            {
                writer.WriteLine("Just text!"); //writes the string "Hello file!" and line change to the file
                writer.Write("More text.");
                writer.Write(" And a little extra."); // writes the string "And a little extra" to the file without a line change
            }
        }
    }
}

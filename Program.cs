namespace Zachary_Renyhart_Week_2_Challenge__2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            
                StreamWriter writer = new StreamWriter("D:\\Challenge2.txt");
                writer.WriteLine("Hello and welcome!");
                writer.WriteLine("This is the first content of my new text file");

                writer.Close();


                string line;
                StreamReader reader = new StreamReader("D:\\Challenge2.txt");
                line = reader.ReadLine();

                while (line != null)
                {
                    Console.WriteLine(line);
                    line = reader.ReadLine();
                    
                }




            File.Copy("D:\\Challenge2.txt",  "D:\\Challenge2TestCopy.txt" , true ); //You must add the boolean "True" to overwrite the file you copied.
                

                string line2;
                StreamReader reader2 = new StreamReader("D:\\Challenge2TestCopy.txt"); //This now shows the copied information above and displays it a second time but in this file.
                line2 = reader2.ReadLine();


                while (line2 != null)
                {
                    Console.WriteLine(line2);
                    line2 = reader2.ReadLine();
                    
                }

        }
    }
}

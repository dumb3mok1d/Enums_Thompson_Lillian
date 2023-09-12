namespace Enums_Thompson_Lillian
{
    enum Months
    {
        Jan = 1,
        Feb,
        Mar,
        Apr,
        May,
        Jun,
        Jul,
        Aug,
        Sep,
        Oct,
        Nov,
        Dec

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            int myBirthMonth = (int)Months.Aug
            int myBirthDay = 17;
            int myBirthYear = 2005;

            string myBirthDate = $"my bithday is on {myBirthMonth}/{myBirthDay}/{myBirthYear}";

            File.WriteAllText("MyFile.txt", "This is my Text File!");
            Console.WriteLine(File.ReadAllText("Myfile.txt"));

            File.WriteAllText("MyFile.txt", "Yayy more texr was added to the file!\n");
            Console.WriteLine(File.ReadAllText("Myfile.txt"));

            if (!File.Exists("newFile.txt"))
            {
                File.Copy("myFile.txt", "newFile.txt");
            }
            else
            {
                File.Replace("myFile.txt", "newFile.txt", "backFile.txt");
            }

            File.AppendAllText("newFile.txt", myBirthDate);
            Console.WriteLine(File.ReadAllText("myFile.txt"));
        }
    }
}
namespace DiaryManager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string filepath = Path.Combine(Environment.CurrentDirectory, "mydiary.txt");

                //

                int option = 0;

                while (option != 6)
                {
                    Console.WriteLine("\n1.Reading The Entiar Diary.\n2.Add Enties to Your Diary" +
                    "\n3.Delete An Entries.\n4.Counting Numbers Of The Entries.\n5.Read Data For Specific date." +
                   "\n6.Exit");
                    option = int.Parse(Console.ReadLine());
                    
                    if (option == 1)
                    {
                        Console.WriteLine("File content:\n");
                        Console.WriteLine(DailyDiary.ReadAllTextMethod(filepath));
                    }
                    else
                if (option == 2)
                    {
                        Console.WriteLine("Write The date of your content.");
                        string date = Console.ReadLine();
                        Console.WriteLine("Write The your content.");
                        string content = Console.ReadLine();
                        DailyDiary.AddMethod(filepath, new Entry { Date = date }, new Entry { Content = content });
                        Console.WriteLine(DailyDiary.ReadAllTextMethod(filepath));
                    }
                    else
                if (option == 3)
                    {
                        Console.WriteLine("Write the content you want to Delete");
                        string content = Console.ReadLine();
                        DailyDiary.DeleteMethod(filepath, new Entry { Content = content });
                        Console.WriteLine(DailyDiary.ReadAllTextMethod(filepath));
                    }
                    else
                if (option == 4)
                    {
                        Console.WriteLine("your Entries Are Numbers Are:");
                        
                        Console.WriteLine(DailyDiary.CountMethod(filepath));
                    }
                    else if (option == 5)
                    {
                        Console.WriteLine("Enter Your Date to get its Entry");
                        string date = Console.ReadLine();
                        DailyDiary.readByDateMethod(filepath, new Entry { Date = date });
                    }
                    else
                    if (option > 6)
                    {
                        {
                            Console.WriteLine("Choose only from 1-6");
                        }
                    }
                }

            }
            catch (FormatException e)
            {
                Console.WriteLine(e.ToString());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            finally
            {
                Console.WriteLine("done!");
            }
        }
    }
}

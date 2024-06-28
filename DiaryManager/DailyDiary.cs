using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiaryManager
{
    public class DailyDiary
    {
        //read
        public static string ReadAllTextMethod(string filepathParam)
        {
            string txtContent = File.ReadAllText(filepathParam);
            return txtContent;

        }
        //add
        public static string[] AddMethod(string filepathParam, Entry date, Entry content)
        {
            if (DateTime.TryParseExact(date.Date, "yyyy-MM-dd", null, DateTimeStyles.None, out DateTime parsedDate))
            {
                string formattedDate = parsedDate.ToString("yyyy-MM-dd");
                string addedContent = $"\n {formattedDate} \n {content.Content}";
                File.AppendAllText(filepathParam, addedContent);
                string[] strings = File.ReadAllLines(filepathParam);
                return strings;
            }else
            {
                return new string[0];   
            }

        }

        //delete
        public static void DeleteMethod(string filepathParam, Entry content)
        {
            string txtContent = File.ReadAllText(filepathParam);
            txtContent= txtContent.Replace(content.Content, "");
            File.WriteAllText(filepathParam, txtContent);
        }

        //count
        public static int CountMethod(string filepathParam)
        {
            string [] number=File.ReadAllLines(filepathParam);
            return number.Length;

        }

        //readByDate
        public static void readByDateMethod(string filepathParam, Entry date)
        {
            if (DateTime.TryParseExact(date.Date, "yyyy-MM-dd", null, DateTimeStyles.None, out DateTime parsedDate))
            {
                string formattedDate = parsedDate.ToString("yyyy-MM-dd");
              string [] lines=  File.ReadAllLines(filepathParam);
                for (int i = 0; i < lines.Length; i++) 
                { 
                    if (lines[i]== formattedDate)
                    {
                        Console.WriteLine(lines[i+1]);
                    }
                }


            }
        }
    }
}

using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    internal class Program
    {
            static void Main(string[] args)
            {
            Console.WriteLine("Student Data: ");
            Console.WriteLine("ID\tName\tGender\tBranch");
            string directorypath= "C:\\simplilearn\\Project2\\Project2\\";
            List<string> StudentData = ReadStudentData(Path.Combine(directorypath,"StudentData.txt"));
                foreach (string data in StudentData)
                {
                    Console.WriteLine(data);
                }
                Console.ReadKey();
            }
            static List<string> ReadStudentData(string filePath)
            {
                List<string> Studentdata = new List<string>();
                try
                {
                    Studentdata = new List<string>(File.ReadAllLines(filePath));
                }
                catch (IOException ex)
                {
                    Console.WriteLine($"Error reading file: {ex.Message}");
                }
                return Studentdata;
            }
        }
    } 






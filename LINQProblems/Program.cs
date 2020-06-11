using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LINQProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            //PROBLEM 1
            List<string> words = new List<string>();
            words.Add("the");
            words.Add("bike");
            words.Add("this");
            words.Add("it");
            words.Add("tenth");
            words.Add("mathematics");
            var onlyTh = words.Where(w => w.Contains("th") );

            //PROBLEM 2
            List<string> names = new List<string>();
            names.Add("Mike");
            names.Add("Brad");
            names.Add("Nevin");
            names.Add("Zack");
            names.Add("Mike");
            var noDuplicates = names.Distinct().ToList();

            //PROBLEM 3
            List<string> grades = new List<string>();
            
            grades.Add("80,100,92,89,65");
            grades.Add("93,81,78,84,69");
            grades.Add("73,88,83,99,64");
            grades.Add("98,100,66,74,55");

            //Convert to int
            //Drop lowest grade for each student
            //averaqge grades
            // average again

            //PROBLEM 4
            List<double> averageGrades = new List<double>();
            for (int i = 0; i < grades.Count ; i++)
            {
                List<double> gradesToDouble = grades[i].Split(',').Select(double.Parse).ToList();
                //get min 
                double min = gradesToDouble.Min();
                List<double> lowestGradeRemoved = gradesToDouble.Where(g => g != min).ToList();

                //get average grades per student
                var averageGradesPerStudent = lowestGradeRemoved.Average();
                
                averageGrades.Add(averageGradesPerStudent);

                //get total average grades
                
            }
            var totalAverageGrades = averageGrades.Average();

            //PROGRAM 5

            string toCount = "Terrill";

            //create almost like a dictionary as to how I solved before not using link
            try
            {
                var listOfStrings = from character in toCount group character by character into newCharacter select newCharacter;
                foreach (var element in listOfStrings)
                {
                    //Couldnt figure out how to print the letter but the count is right
                    Console.WriteLine($"{element.Count()}");
                }
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine(e); 
            }



                Console.ReadLine();
        }
    }
}

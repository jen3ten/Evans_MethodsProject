using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Timers;

namespace Week5_MethodsProject_02062016
{
    class Program
    {
        //All METHODS are listed here

        //UserName allows you to enter your name and phone number and saves them to variables
        static void UserName()
        {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Please enter your phone number: ");
            string phone = Console.ReadLine();
        }
        
        //ProperName takes a sentence that starts with a first name and last name
        //and returns the sentence with the first and last name in Title case
        static string ProperName(string sentence)
        {
            string[] sentenceArray = sentence.Split();  //split the sentence string into a string array of words
            StringBuilder newSentence = new StringBuilder();  //define a new Stringbuilder to recreate the sentence after it has been modified
            for (int i = 0; i < 2; i++)         //for the first two words only...
            {
                sentenceArray[i] = sentenceArray[i].ToLower();  //put the entire word in lower case
                char[] word = sentenceArray[i].ToCharArray();   //assign the word to a character array
                string upperLetter = word[0].ToString().ToUpper();//convert first character to a string and capitalize the first letter of the word
                newSentence.Append(upperLetter);    //append the first letter to the stringbuilder
                for (int j = 1; j < word.Length; j++) //from the second letter to the end of the word
                { 
                    newSentence.Append(word[j]);    //then append the rest of the word to stringbuilder
                }
                newSentence.Append(" "); //and add a space to stringbuilder at the end of the word
            }
            for (int i = 2; i < sentenceArray.Length; i++) //for the remainder of the words in the sentence
            {
                newSentence.Append(sentenceArray[i]); //append the word to stringbuilder
                newSentence.Append(" ");    //and add a space
            }
            return newSentence.ToString(); //return the stringbuilder that has been converted to a string
        }
        
        //PrintArray takes a string array and prints one string per line
        static void PrintArray(string sentence)
        {
            string[] sentenceArray = sentence.Split();
            foreach (string word in sentenceArray)
            {
                Console.WriteLine(word);
            }
        }
         
        //FamilyGuy takes a list of Family Guy characters and prints them one per line
        static void FamilyGuy(string characters)
        {
            string[] characterArray = characters.Split(','); //split the array at the comma
            foreach (string character in characterArray)
            {
                Console.WriteLine(character.TrimStart()); //print the character string, and trim starting space
            }
        }

        //Top Student finds the average scores of grades
        static double TopStudent(string grades)
        {
            double gradeTotal = 0;
            string[] gradesArray = grades.Split(','); //split the grades array at the comma
            foreach (string grade in gradesArray)
            {
                double gradeNum = double.Parse(grade);
                gradeTotal += gradeNum;     //Create a total of the grades
            }

            double average = gradeTotal / (gradesArray.Length); //Calculate the average
            return average;     //return the average to the main method
        }
        
        //AlphaSplitter takes a string and returns an alphabetized list of the words, one per line
        static void AlphaSplitter(string sentence)
        {
            string[] sentenceArray = sentence.Split();
            Array.Sort(sentenceArray);
            foreach (string word in sentenceArray)
            {
                Console.WriteLine(word);
            }
        }
        
        //SorbrietyTest prints the alphabet in reverse order
        static void SobrietyTest()
        {
            char[] alpha = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            Array.Sort(alpha);
            Array.Reverse(alpha);
            Console.WriteLine(alpha);
        }

        //LostTeeth Method
        //Ask user for a year in the future (check to make sure input > 2016)
        //Calculate number of years passed
        //Formula for predicted loss of teeth is 1 tooth per every 3 years
        //Output number of teeth to the console as a whole number
        //If there is a remainder (mod), there is an additional tooth that is wiggly
        //Call LostTeeth with year as parameter
        static void LostMyTeeth(int year)
        {
            int yearsPassed = year - 2016;
            if (yearsPassed <= 0)
            {
                Console.WriteLine("Please enter a year that is greater than 2016.");
                return;
            }
            int numTeeth = yearsPassed / 3;
            string teeth = "teeth";
            if (numTeeth == 1)
                teeth = "tooth";
            Console.Write("By {0} I predict you will have lost {1} {2}", year, numTeeth, teeth);
            if (yearsPassed % 3 > 0)
            {
                Console.WriteLine(" and will have one wiggly tooth.");
            }
            else
                Console.WriteLine(".");
        }

        static void BuildHouse(int scale)
        {
            int size = 1 * scale;
            int roof = scale + 2;
            for (int b = 0; b < roof; b++)
            {
                Console.Write("#");
            }
            Console.WriteLine();
            for (int row = 0; row < size-1; row++)
            {
                for (int col = 0; col < roof; col++)
                {
                    if (col == 1 || col == (roof - 2))
                        Console.Write("#");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }
            for (int col = 0; col < roof; col++)
            {
                if (col == 0 || col == roof-1)
                    Console.Write(" ");
                else
                    Console.Write("#");
            }
            Console.WriteLine();
        }

        //Displays a timer that will count down from the hours, minutes, and seconds entered
        static void CountdownTimer(string time)
        {
            string[] timeArray = time.Split(':');
            int hours = int.Parse(timeArray[0]);
            int minutes = int.Parse(timeArray[1]);
            int seconds = int.Parse(timeArray[2]);
            int totalSecs = (hours * 3600) + (minutes * 60) + seconds;
            for (int i = totalSecs; i >= 0; i--)
            {
                Console.Clear();
                int numHours = i / 3600;
                int numMins = (i % 3600) / 60;
                int numSecs = (i % 3600) % 60;
                Console.WriteLine("Counting down...{0:d2}:{1:d2}:{2:d2}", numHours, numMins, numSecs);
                System.Threading.Thread.Sleep(1000);
            }
            Console.WriteLine("The End...");
        }

        //NameAgeState Method
        //Take information and prints information into a current sentence
        static void NameAgeState(string name, string age, string state)
        {
            Console.WriteLine($"Hey {name}! I can't believe you are {age} years old.  That's why you live in {state}.");
            return;
        }

        //ValidName Verifies first and last name for just letters and prints both if valid
        static bool ValidName(string first, string last)
        {
            if (Regex.IsMatch(first, @"^[a-z,A-Z]+$") && Regex.IsMatch(last, @"^[a-z,A-Z]+$"))
            {
                Console.WriteLine($"Hello, {first} {last}!");
                return true;
            }
            else
            {
                Console.WriteLine("The first and/or last name is not valid.");
                return false;
            }
        }

        //CircleArea returns the area of a circle, given the radius
        static double CircleArea(double radius)
        {
            double area = radius * radius * Math.PI;
            return area;
        }

        //NumberCheck checks the array of number entered
        //If they are all numbers, the method will return true
        //If characters other than numbers exist, the method will return false
        static bool NumberCheck(string numbers)
        {
            string[] numSplit = numbers.Split(',');
            foreach (string number in numSplit)
            {
                if (!(Regex.IsMatch(number.TrimStart(), @"^\d+$")))
                    return false;
            }
            return true;
        }

        //Start the Main Method
        static void Main(string[] args)
        {
            bool notValid = true;
            int selection = 0;
            do
            {
                Console.WriteLine("Choose from the following menu of METHODS:");
                Console.WriteLine();
                Console.WriteLine("1. Username");
                Console.WriteLine("2. Proper Name");
                Console.WriteLine("3. Print Array");
                Console.WriteLine("4. Family Guy");
                Console.WriteLine("5. Top Student");
                Console.WriteLine("6. Alpha Splitter");
                Console.WriteLine("7. Sobriety Test");
                Console.WriteLine("8. Lost My Teeth");
                Console.WriteLine("9. Build House");
                Console.WriteLine("10. Countdown Timer");
                Console.WriteLine("11. Name Age State");
                Console.WriteLine("12. Valid Name");
                Console.WriteLine("13. Circle Area");
                Console.WriteLine("14. Number Check");
                Console.WriteLine("15. EXIT");
                Console.WriteLine();

                bool parsed = Int32.TryParse(Console.ReadLine(), out selection);
                Console.Clear();

                if (!parsed || selection < 1 || selection > 15)
                {
                    Console.WriteLine("INVALID ENTRY...Please enter a number between 1 - 15");
                    Console.WriteLine();
                }
                else
                {
                    notValid = false;
                }

            } while (notValid);

            switch (selection)
            {
                case 1:
                    UserName();
                    break;
                case 2:
                    Console.Write("Enter a sentence that starts with your first and last name: ");
                    string sentence = Console.ReadLine();
                    string newSentence = ProperName(sentence);
                    Console.WriteLine(newSentence);
                    break;
                case 3:
                    Console.Write("Please enter a sentence: ");
                    sentence = Console.ReadLine();
                    PrintArray(sentence);
                    break;
                case 4:
                    Console.Write("Please enter Family Guy characters, separated by a comma: ");
                    string characters = Console.ReadLine();
                    FamilyGuy(characters);
                    break;
                case 5:
                    string topStudent;
                    double topAverage;
                    Console.Write("What is the name of the first student? ");
                    string student1 = Console.ReadLine();
                    Console.Write("Enter 3 grades for {0}, separated by commas: ", student1 );
                    string grades1 = Console.ReadLine();
                    double average1 = TopStudent(grades1);
                    Console.Write("What is the name of the second student? ");
                    string student2 = Console.ReadLine();
                    Console.Write("Enter 3 grades for {0}, separated by commas: ", student2);
                    string grades2 = Console.ReadLine();
                    double average2 = TopStudent(grades2);
                    if (average1 > average2)
                    {
                        topStudent = student1;
                        topAverage = average1;
                    }
                    else if (average2 > average1)
                    {
                        topStudent = student2;
                        topAverage = average2;
                    }
                    else
                    {
                        Console.WriteLine("Both {0} and {1} had an average score of {2:f2}.", student1, student2, average1);
                        break;
                    } 
                    Console.WriteLine("{0}'s average score of {1:f2} was the highest!", topStudent, topAverage);
                    break;
                case 6:
                    Console.Write("Please enter a sentence: ");
                    sentence = Console.ReadLine();
                    AlphaSplitter(sentence);
                    break;
                case 7:
                    Console.WriteLine("Press any key to see the alphabet in reverse.");
                    Console.ReadLine();
                    SobrietyTest();
                    break;
                case 8:
                    Console.WriteLine("I am going to predict how many teeth you will lose.");
                    Console.Write("Please enter a year in the future: ");
                    int year = int.Parse(Console.ReadLine());
                    LostMyTeeth(year);
                    break;
                case 9:
                    Console.WriteLine("I am going to build you a Frank Lloyd style house for Valentine's Day.");
                    int scale;
                    do
                    {
                        Console.Write("What size house do you want? (1-20) ");
                        scale = int.Parse(Console.ReadLine());
                        if (scale >= 1 && scale <= 20)
                            break;
                    } while (true);
                    if (scale == 20)
                        Console.WriteLine("Of course you do...");
                    else if (scale == 1)
                        Console.WriteLine("Awww, that's a tiny house...");
                    Console.WriteLine();
                    BuildHouse(scale);
                    break;
                case 10:
                    Console.WriteLine("This is a countdown timer.");
                    Console.WriteLine("Count down from how many hours, minutes, and seconds?");
                    Console.Write("Enter integers in the format 'hours:minutes:seconds' - ");
                    string timeString = Console.ReadLine();
                    CountdownTimer(timeString);
                    break;
                case 11:
                    Console.Write("What is your name? ");
                    string name = Console.ReadLine();
                    Console.Write("What is you age? ");
                    string age = Console.ReadLine();
                    Console.Write("What state are you from? ");
                    string state = Console.ReadLine();
                    NameAgeState(name, age, state);
                    break;
                case 12:
                    bool valid = false;
                    do
                    {
                        Console.Write("Enter a first name: ");
                        string first = Console.ReadLine();
                        Console.Write("Enter a last name: ");
                        string last = Console.ReadLine();
                        valid = ValidName(first, last);
                    } while (!valid);
                    break;
                case 13:
                    Console.Write("Enter the radius of a circle, and I will calculate the area: ");
                    double radius = double.Parse(Console.ReadLine());
                    double area = CircleArea(radius);
                    Console.WriteLine("The area of the circle is {0:f2}", area);
                    break;
                case 14:
                    bool isInt;
                    Console.Write("Enter some integers, separated by commas: ");
                    string numbers = Console.ReadLine();
                    isInt = NumberCheck(numbers);
                    if (isInt)
                        Console.WriteLine("You entered integers.");
                    else
                        Console.WriteLine("You did not enter integers.");
                    break;
                case 15:
                default:
                    break;
            }
            Console.WriteLine();
            Console.WriteLine("Press any key to see the menu or 'X' to exit." );
            string input = Console.ReadLine();
            if (input != "x" && input != "X")
            {
                Console.Clear();
                Main(args);
            }
        }
    }
}

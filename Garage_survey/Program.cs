using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage_survey
{
    class Program
    {
        static void Main(string[] args)
        {
            string characterName = "Toncha";
            int characterAge;
            characterAge = 35;


            Console.WriteLine("    /|");
            Console.WriteLine("   / |");
            Console.WriteLine("  /  |");
            Console.WriteLine(" /   |");
            Console.WriteLine("/____|");

            Console.WriteLine("Threr once was a man name " + characterName);
            Console.WriteLine("He was" + characterAge + " years old");
            Console.WriteLine("He really liked the name " + characterName);
            Console.WriteLine("But didn't like being " + characterAge);



            string phrase = "Chawalwat Poosawatrattana";
            Console.WriteLine(phrase[1]); //print out character
            Console.WriteLine(phrase.IndexOf("Poo"));
            Console.WriteLine(phrase.IndexOf("z")); 
            Console.WriteLine(phrase.Substring(4));
            Console.WriteLine(phrase.Substring(4 , 3)); //start at index 4 and show 3 leatter after that

            Console.WriteLine(5.654 + 2 );
            int wholeNum = 45;
            long wholeNum1 = 86541;
            double decimalNum = 5.55D;
            decimal decimalNum1 = 5.6789101M;


            Console.WriteLine("Question1");
            Console.Write("Ans : ");
            string ans1 = Console.ReadLine();

            Console.WriteLine("Question2");
            Console.Write("Ans : ");
            string ans2 = Console.ReadLine();

            Console.WriteLine("Question3");
            Console.Write("Ans : ");
            string ans3 = Console.ReadLine();

            Console.WriteLine("Question4");
            Console.Write("Ans : ");
            string ans4 = Console.ReadLine();

            Console.WriteLine("Question5");
            Console.Write("Ans : ");
            string ans5 = Console.ReadLine();

            Console.WriteLine("Ans : " + ans1);
            Console.WriteLine("Ans : " + ans2);
            Console.WriteLine("Ans : " + ans3);
            Console.WriteLine("Ans : " + ans4);
            Console.WriteLine("Ans : " + ans5);

            Console.ReadLine();
        }
    }
}

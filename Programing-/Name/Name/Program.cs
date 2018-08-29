using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Name
{
    class person
    {

    }
    class Program
    {
        static void Main()
        {           
            int Task = 0;
            Boolean MenuSystem = true;
            //Console.WindowWidth = 140;
            //Console.WindowHeight = 40;
            Console.WindowHeight = 31;
            //Console.SetWindowSize(50, 40);//Sets the size of the window
            //Console.BufferWidth = 51;//Add a border
            //Console.SetCursorPosition(32, 10)
            //Console.BackgroundColor = ConsoleColor.DarkYellow;
            //Console.ForegroundColor = ConsoleColor.DarkYellow;
            //Console.Clear();

            do
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine(String.Format("{0," + Console.WindowWidth / 2 + "}", "---Welcome!---"));
                //Console.WriteLine("\n     --Welcome!---");
                Console.WriteLine("\n       ---Hello!---");
                Console.WriteLine("What would you like to do?\n");
                Console.ResetColor();
               
                Console.WriteLine(" > Topic 1-2 <");              
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("Type 1 for Task 1");
                Console.WriteLine("Type 2 for Task 2");
                Console.WriteLine("Type 3 for Task 3");
                Console.ResetColor();

                Console.WriteLine("\n  > Topic 3 <");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("Type 4 for Task 1");
                Console.WriteLine("Type 5 for Task 2");
                Console.WriteLine("Type 6 for Task 3");
                Console.WriteLine("Type 7 for Task 4");
                Console.WriteLine("Type 8 for Task 5");
                Console.WriteLine("Type 9 for Task 6");
                Console.ResetColor();

                Console.WriteLine("\n> Topic 3 Part 2 <");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("Type 10 for Task 1");
                Console.WriteLine("Type 11 for Task 2");
                Console.ResetColor();

                Console.WriteLine("\n> Topic 4 <");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("Type 12 for Task 1");
                Console.WriteLine("Type 13 for Task 2");
                Console.WriteLine("Type 14 for Task 3");
                Console.ResetColor();

                Console.WriteLine("\nType 0 to Exit...\n");
                

                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Picked: ");
                Task = Convert.ToInt32(Console.ReadLine());
                Console.Write("\n");
                Console.ResetColor();

                if (Task == 1) { YouFunctions(); break; }
                if (Task == 2) { MathFunctions(); break; }
                if (Task == 3) { NameFunctions(); break; }
                if (Task == 4) { GuessMyNumFunctions(); break; }
                if (Task == 5) { ComparingIntegers(); break; }
                if (Task == 6) { GradeFunctions(); break; }
                if (Task == 7) { OddOrEvenFunctions(); break; }
                if (Task == 8) { PinNumberFunctions(); break; }
                if (Task == 9) { PalindromeFunctions(); break; }
                if (Task == 10) { GuessMyFavoritePetFunctions(); break; }
                if (Task == 11) { PriceOfTheFruitFunctions(); break; }
                if (Task == 12) { AllTheLoopsFunctions(); break; }
                if (Task == 13) { TimesTablesFunctions(); break; }
                if (Task == 14) { NumberSquaresCubesFunctions(); break; }
                if (Task == 15) { OddNumbersFunctions(); break; }
                if (Task == 16) { RepeatCharacterFunctions(); break; }
                if (Task == 17) { RectangleFunctions(); break; }
                if (Task == 100) { Colors(); break; }
                if (Task == 0) { Environment.Exit(0); }
                else if (Task >= 18 && Task != 100) { MenuElse(); Console.Clear(); }

            } while (MenuSystem);
       
        }  
        public static void YouFunctions()
        {
            //------------------------Task 1------------------------\\

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("*--------------WhoYou--------------*");
            Console.ResetColor();
            string YourName; //Adding a string. 
            Console.Write("Whats your name? "); //Printing out Whats your name while you are able to type in 1 line.
            YourName = Console.ReadLine(); //Using ReadLine to take users input into a string.    

            string LastName;
            Console.Write("Whats your last name? ");
            LastName = Console.ReadLine();

            string Gender;
            Console.Write("Are you Male Or Female? ");
            Gender = Console.ReadLine();

            float Age;
            Console.Write("Whats your Age? ");
            Age = float.Parse(Console.ReadLine());

            Console.WriteLine("\nOk Your {0}!", YourName); //Printing The stirng.
            Console.WriteLine("\nYour last name is {0}!", LastName);

            if (Age <= 1) //Age is less then 1
            {
                Console.WriteLine("\nYou are a Baby!", Age); //Print what you are.
            }
            if (Age <= 3) //Age is less then 3
            {
                Console.WriteLine("\nYou are Little Kid!", Age);
            }
            if (Age >= 4 && Age <= 12) //Age is between 4 and 12
            {
                Console.WriteLine("\nAnd your a Kid!", Age);
            }
            if (Age >= 13 && Age <= 20) //Age is between 13 and 20
            {
                Console.WriteLine("\nAnd your Teen!", Age);
            }
            if (Age >= 21 && Age <= 29) //Age is between 21 and 29
            {
                Console.WriteLine("\nAnd your Young adult!", Age);
            }
            if (Age >= 30 && Age <= 49) //Age is between 30 and 49
            {
                Console.WriteLine("\nYour a Adult!", Age);
            }
            else if (Age >= 50 && Age <= 99) //Age is between 50 and 99
            {
                Console.WriteLine("\nYou are a Old Person!", Age);
            }
            if (Age >= 100) //Age is more then 100
            {
                Console.WriteLine("\nYou Died!", Age);
            }

            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("\nPress enter to exit...");
            Console.ResetColor();
            Console.ReadLine();
            Console.Clear();
            Main();

        }
        public static void MathFunctions()
        {
            //------------------------Task 2------------------------\\

            Console.Clear();
            Int64 NumOne, NumTwo;
            string Choice;
            Int64 Answer = 0;
            //float Cal1;
            //float Cal2;
            //float Cal3;
            //float Cal4;
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\n*--------------PlusCalculation--------------*");
            Console.ResetColor();

            Console.Write("\nEnter Your 1st number: "); //Users 1st number imput.
            NumOne = Int64.Parse(Console.ReadLine());
            Console.Write("Enter Your 2nd number: ");  //Users 1nd number imput.
            NumTwo = Int64.Parse(Console.ReadLine());

            Console.Write("What would you like to do? (+) (-) (*) (/): ");  //Users choice imput
            Choice = Console.ReadLine();

            if (Choice == "+")
            {
                Answer = NumTwo + NumOne;
            }
            if (Choice == "-")
            {
                Answer = NumTwo - NumOne;
            }
            if (Choice == "*")
            {
                Answer = NumTwo * NumOne;
            }
            if (Choice == "/")
            {
                Answer = NumTwo / NumOne;
            }

            Console.WriteLine("Answer: {0} {1} {2} = {3:0}", NumOne, Choice, NumTwo, Answer);

            //Cal1 = NumTwo + NumOne;
            //Cal2 = NumTwo - NumOne;
            //Cal3 = NumTwo * NumOne;
            //Cal4 = NumTwo / NumOne;

            //Console.WriteLine("\nAnswer: (+)={0}, (-)={1}, (×)={2}, (÷)={3}", Cal1, Cal2, Cal3, Cal4);

            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("\nPress enter to exit...");
            Console.ResetColor();
            Console.ReadLine();
            Console.Clear();
            Main();
        }
        public static void NameFunctions()
        {
            //------------------------Task 3------------------------\\

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\n*--------------YourName--------------*");
            Console.ResetColor();

            string FirstName; //Adding a string. 
            Console.Write("Whats your name? "); //Printing out Whats your name while you are able to type in 1 line.
            FirstName = Console.ReadLine(); //Using ReadLine to take users input into a string.    

            string LLastName;
            Console.Write("Whats your last name? ");
            LLastName = Console.ReadLine();

            Console.WriteLine("\nHello {0} {1}!", FirstName, LLastName);

            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("\nPress enter to exit...");
            Console.ResetColor();
            Console.ReadLine();
            Console.Clear();
            Main();
        }
        public static void GuessMyNumFunctions()
        {
            //------------------------Task 4------------------------\\

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n*--------------GuessMyNumber--------------*");
            Console.ResetColor();

            int MyNum;

            Console.WriteLine("\nTry to guess my number on 1st try!");
            Console.Write("Guess: ");
            MyNum = Convert.ToInt32(Console.ReadLine());

            if (MyNum == 6)
            {
                Console.WriteLine("\nYou Are a Wizzerd!\n");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("\nPress enter to exit...");
                Console.ResetColor();
                Console.ReadLine();
                Console.Clear();
                Main();

                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("You are Worng!");
                GuessMyNumAddOn();       
            }
        }
        public static void GuessMyNumAddOn()
        {
            int MyNum;
            Console.Write("\nGuess: ");
            MyNum = Convert.ToInt32(Console.ReadLine());

            if (MyNum == 6)
            {
                Console.WriteLine("\nYou got the number right!\n");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("\nPress enter to exit...");
                Console.ResetColor();
                Console.ReadLine();
                Console.Clear();
                Main();
            }
            else if (MyNum < 6)
            {
                Console.WriteLine("Worng!  Hint: Too Low!");
                GuessMyNumAddOn();
            }
            else if (MyNum > 6)
            {
                Console.WriteLine("Worng!  Hint: Too High!");
                GuessMyNumAddOn();
            }
        }
        public static void ComparingIntegers()
        {
            //------------------------Task 5------------------------\\

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n*--------------ComparingNumbers--------------*");
            Console.ResetColor();

            int OneComparing, TwoComparing;

            Console.Write("Whats your 1st number: ");
            OneComparing = Convert.ToInt32(Console.ReadLine());

            Console.Write("Whats your 2nd number: ");
            TwoComparing = Convert.ToInt32(Console.ReadLine());

            if (OneComparing > TwoComparing)
            {
                Console.WriteLine("\n1st Number: {0} is begger then 2nd Number: {1}",OneComparing, TwoComparing);
            }
            else if (OneComparing < TwoComparing)
            {
                Console.WriteLine("\n2nd Number: {1} is begger then 1st Number: {0}", OneComparing, TwoComparing);
            }

            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("\nPress enter to exit...");
            Console.ResetColor();
            Console.ReadLine();
            Console.Clear();
            Main();
        }
        public static void GradeFunctions()
        {
            //------------------------Task 6------------------------\\

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n*--------------WhatsMyGrade--------------*");
            Console.ResetColor();

            int Grade;

            Console.WriteLine("Write your marks in");
            Console.Write("Mark: ");
            Grade = Convert.ToInt32(Console.ReadLine());

            if (Grade >= 90 && Grade <= 100)
            {
                Console.Write("You got: A+");
            }
            if (Grade >= 80 && Grade <= 89)
            {
                Console.Write("You got: A");
            }
            if (Grade >= 70 && Grade <= 79)
            {
                Console.Write("You got: B+");
            }
            if (Grade >= 60 && Grade <= 69)
            {
                Console.Write("You got: B");
            }
            if (Grade >= 50 && Grade <= 59)
            {
                Console.Write("You got: C");
            }
            if (Grade >= 40 && Grade <= 49)
            {
                Console.Write("You got: D");
            }
            if (Grade >= 0 && Grade <= 39)
            {
                Console.Write("You got: F");
            }
            else if (Grade >= 101)
            {
                Console.WriteLine("Only 0-100 Marks allowed.");
            }

            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("\nPress enter to exit...");
            Console.ResetColor();
            Console.ReadLine();
            Console.Clear();
            Main();
        }
        public static void OddOrEvenFunctions()
        {
            //------------------------Task 7------------------------\\

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("\n*--------------OddOrEven--------------*");
            Console.ResetColor();

            int Number, Answer;

            Console.Write("Enter the Number: ");
            Number = Convert.ToInt32(Console.ReadLine());

            Answer = Number % 2;

            if (Answer == 0)
            {
                Console.WriteLine("Its a Even");
            }
            else if (Answer >= 1)
            {
                Console.WriteLine("Its a Odd");
            }

            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("\nPress enter to exit...");
            Console.ResetColor();
            Console.ReadLine();
            Console.Clear();
            Main();
        }
        public static void PinNumberFunctions()
        {
            //------------------------Task 8------------------------\\

            Console.Clear();
            int Pin;
            int RePin = 0;
            Boolean ThePin = true;
            do
            {
                Console.Write("Enter a 4 digit Number: ");
                Pin = Convert.ToInt32(Console.ReadLine());

                if (Pin < 1000 || Pin > 9999)
                {
                    Console.Write("This PIN number is not within the right parameters");
                }
                else
                {
                    Console.Write("Re-enter the pin: ");
                    RePin = Convert.ToInt32(Console.ReadLine());
                }
                if (RePin == Pin)
                {
                    Console.Write("Accepted");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("\nPress enter to exit...\n");
                    Console.ResetColor();
                    Console.ReadLine();
                    Console.Clear();
                    Main();
                    break;
                }
                else
                {
                    Console.WriteLine("Error! Your PIN numbers did not match. Your PIN was not set. Please try again");
                }
            } while (ThePin);

        }
        public static void PalindromeFunctions()
        {
            //------------------------Task 9------------------------\\

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n*--------------ThePalindrome--------------*");
            Console.ResetColor();

            string One,Two,Three;

            Console.Write("Enter the 1st word: ");
            One = Console.ReadLine();

            Console.Write("Enter the middle word: ");
            Two = Console.ReadLine();

            Console.Write("Enter the 3rd word: ");
            Three = Console.ReadLine();

            if (Two != "a" || Two !="e" || Two != "i" || Two != "o" || Two != "u")
            {
                Console.WriteLine("Not a Palindrome");
            }
            else if (Two != One)
            {
                Console.WriteLine("Is a Palindrome");
            }

            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("\nPress enter to exit...");
            Console.ResetColor();
            Console.ReadLine();
            Console.Clear();
            Main();
        }
        public static void GuessMyFavoritePetFunctions()
        {
            //------------------------Task 10------------------------\\

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\n*--------------GuessMyFavoritePet--------------*");
            Console.ResetColor();

            int pet = 1;

            Console.WriteLine("Guess the pet");
            pet = Convert.ToInt32(Console.ReadLine());

            switch (pet)
            {
                case 1:
                    Console.WriteLine("HI");
                    break;
                case 2:
                    Console.WriteLine("HI1");
                    break;
                case 3:
                    Console.WriteLine("HI2");
                    break;
                case 4:
                    Console.WriteLine("HI3");
                    break;

            }

            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("\nPress enter to exit...");
            Console.ResetColor();
            Console.ReadLine();
            Console.Clear();
            Main();
        }
        public static void PriceOfTheFruitFunctions()
        {
            //------------------------Task 11------------------------\\

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n*--------------What is the Price of the Fruit?--------------*");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("\nPress enter to exit...");
            Console.ResetColor();
            Console.ReadLine();
            Console.Clear();
            Main();
        }
        public static void AllTheLoopsFunctions()
        {
            //------------------------Task 12------------------------\\

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\n*--------------AllTheLoops!--------------*");
            Console.ResetColor();

           
            Console.Write("Enter your starting number: ");
            int num = int.Parse(Console.ReadLine());
            Console.Write("Enter your end number: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("\nFor Loop:\n");

            for (int i = num; i <= num1; i ++)
            {
                //Console.WriteLine($" {i}  {i * 10} {i*100}");
                Console.WriteLine("{0}\t {1}\t  {2}", i, (i * 10), (i * 100));
            }

            int j = num;

            Console.WriteLine("\nWhile Loop:");

            while (j <= num1)
            {
                Console.WriteLine("{0}\t {1}\t  {2}", j, (j * 10), (j * 100));
                j++;
            }

            int k = num;

            Console.WriteLine("\nDo while:");
            do
            {
                Console.WriteLine("{0}\t {1}\t  {2}", k, (k * 10), (k * 100));
                k++;
            } while (k <= num1);

            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("\nPress enter to exit...");
            Console.ResetColor();
            Console.ReadLine();
            Console.Clear();
            Main();
        }
        public static void TimesTablesFunctions()
        {
            //------------------------Task 13------------------------\\

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\n*--------------TimesTables--------------*");
            Console.ResetColor();

            Console.Write("Enter the times table: ");
            int num = int.Parse(Console.ReadLine());
           
            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine("{0}x{1}={2}",(num), i, (i * num));
            }

            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("\nPress enter to exit...");
            Console.ResetColor();
            Console.ReadLine();
            Console.Clear();
            Main();
        }
        public static void NumberSquaresCubesFunctions()
        {
            //-----------------------Task 14------------------------\\

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n*--------------NumberSquaresCubes!--------------*");
            Console.ResetColor();

            int num = 0;

            Console.Write("How much numbers: ");
            int big = int.Parse(Console.ReadLine());
            Console.WriteLine("Num \t Sq \t Cube");
            Console.WriteLine("--- \t -- \t ----");
            Console.WriteLine("0 \t 0 \t 0");

            for (int i =1; i <= big; i++)
            {
                num = i * i;
                
                
                Console.WriteLine("{0}\t {1}\t {2}", i, (i*i), num * i);
            }

            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("\nPress enter to exit...");
            Console.ResetColor();
            Console.ReadLine();
            Console.Clear();
            Main();
        }
        public static void OddNumbersFunctions()
        {
            //-----------------------Task 15------------------------\\

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n*--------------OddNumbers!--------------*");
            Console.ResetColor();

            for (int i = 75; i >= 47; i--)
            {
                if (i % 2 != 47)
                {
                    Console.WriteLine(i);
                }
                i--;
            }

            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("\nPress enter to exit...");
            Console.ResetColor();
            Console.ReadLine();
            Console.Clear();
            Main();
        }
        public static void RepeatCharacterFunctions()
        {
            //-----------------------Task 16------------------------\\

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n*--------------NumberSquaresCubes!--------------*");
            Console.ResetColor();

            Console.Write("Enter a character/symbol: ");
            string symbol = Console.ReadLine();

            Console.Write("Enter counter value: ");
            int times = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= times; i++)
            {
                Console.Write("{0}",symbol);
            }

            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("\nPress enter to exit...");
            Console.ResetColor();
            Console.ReadLine();
            Console.Clear();
            Main();
        }
        public static void RectangleFunctions()
        {
            //-----------------------Task 17------------------------\\

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n*--------------NumberSquaresCubes!--------------*");
            Console.ResetColor();

            Console.Write("Enter the Symbol: ");
            string symbol = Console.ReadLine();
            int witdh = 0;
            int hight = 0;
            Console.Write("Enter Witdh: ");
            witdh = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Hight: ");
            hight = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i <= hight; i++)
            {
                
                Console.Write("{0}", symbol);

                
            }
            for (int i = 0; i <= witdh; i++)
            {
                Console.WriteLine("{0}", symbol);
            }
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("\nPress enter to exit...");
            Console.ResetColor();
            Console.ReadLine();
            Console.Clear();
            Main();
        }
        public static void Colors()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n*--------------ConsoleColoers!--------------*");
            Console.ResetColor();

            Type type = typeof(ConsoleColor);
            Console.ForegroundColor = ConsoleColor.White;
            foreach (var name in Enum.GetNames(type))
            {
                Console.BackgroundColor = (ConsoleColor)Enum.Parse(type, name);
                Console.WriteLine(name);
            }
            Console.BackgroundColor = ConsoleColor.Black;
            foreach (var name in Enum.GetNames(type))
            {
                Console.ForegroundColor = (ConsoleColor)Enum.Parse(type, name);
                Console.WriteLine(name);
            }

            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("\nPress enter to exit...");
            Console.ResetColor();
            Console.ReadLine();
            Console.Clear();
            Main();
        }
        public static void MenuElse()
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("Nothing happend...");

            Console.Write("[Press Enter]");
            Console.ResetColor();

            Console.ReadLine();
        }
    }
}

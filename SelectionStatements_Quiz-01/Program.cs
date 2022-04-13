using System;
using System.Diagnostics;

namespace Operators_Quiz_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello!\nThis will be an exerecise in Selection Statements!");
            AddSpaces(1);
            Console.WriteLine("Try to get the lowest possible score. . .");
            AddSpaces(1);
            Console.Write("Press ENTER to begin the quiz and start the timer: ");
            Console.ReadLine();
            AddSpaces(1);
            Console.Clear();

            Stopwatch sw = Stopwatch.StartNew();


            var answer0 = "if"; // The __ statement is the first form of Selection Statements
            var answer1 = "if/else"; // The __/____ statement is the second form of Selection Statements (include the / in the answer)
            var answer2 = "if/else if/else"; // The __/____/___ statement is the third form of Selection Statements (include the / in the answer)
            var answer3 = "true"; // True or False: You can have as many `else if` statements that you require?
            var answer4 = "true"; // True or False: The Ternary Operator is syntax sugar for an if/else statement?
            var answer5 = "10"; // What is the value of x in this code: if (true){ x = 10; } 
            var answer6 = "10"; // What is the value of x in this code: if (true){ x = 10; } else { x = 11; }
            var answer7 = "10"; // What is the value of x in this code: if (true){ x = 10; } else if (!true) { x = 11; } else { x = 12; }
            var answer8 = "11"; // What is the value of x in this code: int a = 0; int b = 1; if (a > b){ x = 10; } else if (b > a) { x = 11; } else { x = 12; }
            var answer9 = "12"; // What is the value of x in this code: int a = 0; int b = 0; if (a > b){ x = 10; } else if (b > a) { x = 11; } else { x = 12; }
            var answer10 = "true"; // True or False: When we have a Selection Statment that has many `else if's` it's best practice to use a `switch`?
            #region 11
            var answer11 = "100"; //  What is the value of x in this code: const int _favoriteNumber = 7; switch (_favoriteNumber)
            /*{
             * case 0:
             *      x = 0;
             *      break;
             * case 1:
             *      x = 1;
             *      break;
             * case 2: 
             *      x = 2;
             *      break;
             * case 3:
             *      x = 3;
             *      break;
             * case 4:
             *      x = 4;
             *      break;
             * case 5:
             *      x = 5;
             *      break;
             *  case 6:
             *      x = 6;
             *      break;
             *  case 7: 
             *      x = 100;
             *      break;
             *  case 8: 
             *      x = 8;
             *      break;
             *  case 9:
             *      x = 9;
             *      break;
             *  case 10:
             *      x = 10;  
             *      break;  
               default:
                    x = 11;
                    break;
              }*/
            #endregion
            #region 12
            var answer12 = "100"; // What is the value of x in this code: const string Name = "Jack"; switch (Name)
            /*{
             * case "":
             *      x = 0;
             *      break;
             * case "Jack":
             *      x = 100;
             *      break;
             * case "Jill": 
             *      x = 2;
             *      break;
             * case "Jeff":
             *      x = 3;
             *      break;                                                                                                          
               default:
                    x = 4;
                    break;
              }*/
            #endregion
            #region 13
            var answer13 = "Please press the Escape Key to exit"; // What is the value of message in this code:  var key =  Keyboard.Esc; switch (Console.ReadKey())
            /*{
             * case Keyboard.Enter:
             *      message = "Please press the Escape Key to exit";
             *      break;
             * case Keyboard.SpaceBar:
             *      message = "Please press the Escape Key to exit";
             *      break;
             * case Keyboard.Tab:
             *      message = "Please press the Escape Key to exit";
             *      break;
             * case Keyboard.Shift:
             *      message = "Please press the Escape Key to exit";
             *      break;                                                                                                          
               default:
                    message = "Invalid Key Press! Please press the Escape Key to exit";
                    break;
              }*/
            #endregion
            #region 14
            var answer14 = "6"; // What is the value of x in this code: /* int x = 0;
                                //                                         int a = 100;
                                //                                         int b = 200;
                                //                                         int c = 300;
                                //                                         if (a == 100)
                                //                                         {
                                //                                              x += 1;
                                //                                         }
                                //                                         if (b == 200)
                                //                                         {
                                //                                              x += 2;
                                //                                         }
                                //                                         if (c == 300)
                                //                                         {
                                //                                              x += 3;
                                //                                         }*/ 
            #endregion
            #region 15
            var answer15 = "5"; // What is the value of x in this code: /* int x = 0;
                                //                                         int a = 100;
                                //                                         int b = 200;
                                //                                         int c = 300;
                                //                                         if (a != 100)
                                //                                         {
                                //                                              x += 1;
                                //                                         }
                                //                                         if (b == 200)
                                //                                         {
                                //                                              x += 2;
                                //                                         }
                                //                                         if (c == 300)
                                //                                         {
                                //                                              x += 3;
                                //                                         }
                                //                                         */  
            #endregion
            #region 16
            var answer16 = "3"; // What is the value of x in this code: /* int x = 0;
                                //                                         int a = 100;
                                //                                         int b = 200;
                                //                                         int c = 300;
                                //                                         if (a != 100)
                                //                                         {
                                //                                              x += 1;
                                //                                         }
                                //                                         if (b != 200)
                                //                                         {
                                //                                              x += 2;
                                //                                         }
                                //                                         if (c == 300)
                                //                                         {
                                //                                              x += 3;
                                //                                         }*/ 
            #endregion
            #region 17
            var answer17 = "7"; // What is the value of x in this code: /* int x = 0;
                                //                                         int a = 100;
                                //                                         int b = 200;
                                //                                         int c = 300;
                                //                                         if (a != 100)
                                //                                         {
                                //                                              x += 1;
                                //                                         }
                                //                                         if (b != 200)
                                //                                         {
                                //                                              x += 2;
                                //                                         }
                                //                                         if (c != 300)
                                //                                         {
                                //                                              x += 3;
                                //                                         }
                                //                                         x = 7;
                                //                                         */  

            #endregion
            #region 18
            var answer18 = "3"; // What is the value of x in this code: /* int x = 0;
                                //                                         int a = 100;
                                //                                         int b = 200;
                                //                                         int c = 300;
                                //                                         if (a == 100)
                                //                                         {
                                //                                              x += 1;
                                //                                         }
                                //                                         else if (b == 200)
                                //                                         {
                                //                                              x += 2;
                                //                                         }
                                //                                         else
                                //                                         {
                                //                                              x += 3;
                                //                                         }*/

            #endregion
            #region 19
            var answer19 = "ternary"; // This expression uses the _______ operator: \t var answer = a > b ? 1000 : -1000;
            #endregion

            var wrongCount = 0;
            string guess;
            do
            {
                Console.WriteLine("The __ statement is the first form of Selection Statements");
                guess = Console.ReadLine();
                if (guess == answer0)
                {
                    Console.WriteLine("Correct!");
                    AddSpaces(1);
                }
                else
                {
                    Console.WriteLine("Try again");
                    wrongCount++;
                }
                Console.Clear();

            } while (answer0 != guess);
            
            do
            {
                Console.WriteLine("The __/____ statement is the second form of Selection Statements (include the / in the answer)");
                guess = Console.ReadLine();
                if (guess == answer1)
                {
                    Console.WriteLine("Correct!");
                    AddSpaces(1);
                }
                else
                {
                    Console.WriteLine("Try again");
                    wrongCount++;
                }
                Console.Clear();

            } while (answer1 != guess);

            do
            {
                Console.WriteLine("The __/____/___ statement is the third form of Selection Statements (include the / in the answer)");
                guess = Console.ReadLine();
                if (guess == answer2)
                {
                    Console.WriteLine("Correct!");
                    AddSpaces(1);
                }
                else
                {
                    Console.WriteLine("Try again");
                    wrongCount++;
                }
                Console.Clear();

            } while (answer2 != guess);
            
            do
            {
                Console.WriteLine("True or False: You can have as many `else if` statements that you require??");
                guess = Console.ReadLine();
                if (guess == answer3)
                {
                    Console.WriteLine("Correct!");
                    AddSpaces(1);
                }
                else
                {
                    Console.WriteLine("Try again");
                    wrongCount++;
                }
                Console.Clear();

            } while (answer3 != guess);
           
            do
            {
                Console.WriteLine("True or False: The Ternary Operator is syntax sugar for an if/else statement?");
                guess = Console.ReadLine();
                if (guess == answer4)
                {
                    Console.WriteLine("Correct!");
                    AddSpaces(1);
                }
                else
                {
                    Console.WriteLine("Try again");
                    wrongCount++;
                }
                Console.Clear();

            } while (answer4 != guess);
           
            do
            {
                Console.WriteLine("What is the value of x in this code: \n\nint x = 0; \n\nif (true)\n{ \n\tx = 10; \n} ");
                guess = Console.ReadLine();
                if (guess == answer5)
                {
                    Console.WriteLine("Correct!");
                    AddSpaces(1);
                }
                else
                {
                    Console.WriteLine("Try again");
                    wrongCount++;
                }
                Console.Clear();

            } while (answer5 != guess);
           
            do
            {
                Console.WriteLine("What is the value of x in this code: \n\n int x = 10; \n\nif (true)\n{ \n\tx = 10; \n} \nelse \n{ \n\tx = 11; \n}");
                guess = Console.ReadLine();
                if (guess == answer6)
                {
                    Console.WriteLine("Correct!");
                    AddSpaces(1);
                }
                else
                {
                    Console.WriteLine("Try again");
                    wrongCount++;
                }
                Console.Clear();

            } while (answer6 != guess);
           
            do
            {
                Console.WriteLine("What is the value of x in this code: \n\n int x = 0; \n\nif (true)\n{ \n\tx = 10; \n} \nelse if (!true) \n{ \n\tx = 11; \n} \nelse \n{ \n\tx = 12; \n}");
                guess = Console.ReadLine();
                if (guess == answer7)
                {
                    Console.WriteLine("Correct!");
                    AddSpaces(1);
                }
                else
                {
                    Console.WriteLine("Try again");
                    wrongCount++;
                }
                Console.Clear();

            } while (answer7 != guess);
          
            do
            {
                Console.WriteLine("What is the value of x in this code: \n\nint x = 0; \nint a = 0; \nint b = 1; \nif (a > b)\n{ \n\tx = 10; \n} \nelse if (b > a) \n{ \n\tx = 11; \n} \nelse \n{ \n\tx = 12; \n}");
                guess = Console.ReadLine();
                if (guess == answer8)
                {
                    Console.WriteLine("Correct!");
                    AddSpaces(1);
                }
                else
                {
                    Console.WriteLine("Try again");
                    wrongCount++;
                }
                Console.Clear();

            } while (answer8 != guess);
           
            do
            {
                Console.WriteLine("What is the value of x in this code: \n\nint a = 0; \nint b = 0; \nif (a > b)\n{ \n\tx = 10; \n} \nelse if (b > a) \n{ \n\tx = 11; \n} else \n{ \n\tx = 12; \n}");
                guess = Console.ReadLine();
                if (guess == answer9)
                {
                    Console.WriteLine("Correct!");
                    AddSpaces(1);
                }
                else
                {
                    Console.WriteLine("Try again");
                    wrongCount++;
                }
                Console.Clear();

            } while (answer9 != guess);
          
            do
            {
                Console.WriteLine("True or False: When we have a Selection Statment that has many `else if's` it's best practice to use a `switch`?");
                guess = Console.ReadLine();
                if (guess == answer10)
                {
                    Console.WriteLine("Correct!");
                    AddSpaces(1);
                }
                else
                {
                    Console.WriteLine("Try again");
                    wrongCount++;
                }
                Console.Clear();

            } while (answer10 != guess);
          
            do
            {
                Console.WriteLine("What is the value of x in this code: \n\nint x = 0; \n\nconst int _favoriteNumber = 7;\n\nswitch (_favoriteNumber)\n{\ncase 0:\n\tx = 0;\n\tbreak;\ncase 1:\n\tx = 1;\n\tbreak;\ncase 2:\n\tx = 2;\n\tbreak;\ncase 3:\n\tx = 3;\n\tbreak;\ncase 4:\n\tx = 4;\n\tbreak;\ncase 5:\n\tx = 5;\n\tbreak;\ncase 6:\n\tx = 6;\n\tbreak;\ncase 7:\n\tx = 100;\n\tbreak;\ncase 8:\n\tx = 8;\n\tbreak;\ncase 9:\n\tx = 9;\n\tbreak;\ncase 10:\n\tx = 10;\n\tbreak;\ndefault:\n\tx = 11;\n\tbreak;\n}");
                guess = Console.ReadLine();
                if (guess == answer11)
                {
                    Console.WriteLine("Correct!");
                    AddSpaces(1);
                }
                else
                {
                    Console.WriteLine("Try again");
                    wrongCount++;
                }
                Console.Clear();

            } while (answer11 != guess);
           
            do
            {
                Console.WriteLine("What is the value of x in this code: \n\nint x = 0; \nconst string Name = \"Jack\"; \n\nswitch (Name)\n{\ncase \"\":\n\tx = 0;\n\tbreak;\ncase \"Jack\":\n\tx = 100;\n\tbreak;\ncase \"Jill\":\n\tx = 2;\n\tbreak;\ncase \"Jeff\":\n\tx = 3;\n\tbreak;\ndefault:\n\tx = 4;\n\tbreak;\n}");
                guess = Console.ReadLine();
                if (guess == answer12)
                {
                    Console.WriteLine("Correct!");
                    AddSpaces(1);
                }
                else
                {
                    Console.WriteLine("Try again");
                    wrongCount++;
                }
                Console.Clear();

            } while (answer12 != guess);
           
            do
            {
                Console.WriteLine("What is the value of message in this code (Assume you pressed the ENTER key):  \n\nswitch (Console.ReadKey())\n{\ncase Keyboard.Enter:\n\tmessage = \"Please press the Escape Key to exit\";\n\tbreak;\ncase Keyboard.SpaceBar:\n\tmessage = \"Please press the Escape Key to exit\";\n\tbreak;\ncase Keyboard.Tab:\n\tmessage = \"Please press the Escape Key to exit\";\n\tbreak;\ncase Keyboard.Shift:\n\tmessage = \"Please press the Escape Key to exit\";\n\tbreak;\ndefault:\n\tmessage = \"Invalid Key Press! Please press the Escape Key to exit\";\n\tbreak;\n}");
                guess = Console.ReadLine();
                if (guess == answer13)
                {
                    Console.WriteLine("Correct!");
                    AddSpaces(1);
                }
                else
                {
                    Console.WriteLine("Try again");
                    wrongCount++;
                }
                Console.Clear();

            } while (answer13 != guess);
           
            do
            {
                Console.WriteLine("What is the value of x in this code:  \n\nint x = 0;\nint a = 100;\nint b = 200;\nint c = 300;\nif (a == 100)\n{\n\tx += 1;\n}\nif (b == 200)\n{\n\tx += 2;\n}\nif (c == 300)\n{\n\tx += 3;\n}");
                guess = Console.ReadLine();
                if (guess == answer14)
                {
                    Console.WriteLine("Correct!");
                    AddSpaces(1);
                }
                else
                {
                    Console.WriteLine("Try again");
                    wrongCount++;
                }
                Console.Clear();

            } while (answer14 != guess);
          
            do
            {
                Console.WriteLine("What is the value of x in this code: /* \n\nint x = 0;\nint a = 100;\nint b = 200;\nint c = 300;\nif (a != 100)\n{\n\tx += 1;\n}\nif (b == 200)\n{\n\tx += 2;\n}\nif (c == 300)\n{\n\tx += 3;\n} ");
                guess = Console.ReadLine();
                if (guess == answer15)
                {
                    Console.WriteLine("Correct!");
                    AddSpaces(1);
                }
                else
                {
                    Console.WriteLine("Try again");
                    wrongCount++;
                }
                Console.Clear();

            } while (answer15 != guess);
         
            do
            {
                Console.WriteLine("What is the value of x in this code: /* \n\nint x = 0;\nint a = 100;\nint b = 200;\nint c = 300;\nif (a != 100)\n{\n\tx += 1;\n}\nif (b != 200)\n{\n\tx += 2;\n}\nif (c == 300)\n{\n\tx += 3;\n}\nx = 7;");
                guess = Console.ReadLine();
                if (guess == answer16)
                {
                    Console.WriteLine("Correct!");
                    AddSpaces(1);
                }
                else
                {
                    Console.WriteLine("Try again");
                    wrongCount++;
                }
                Console.Clear();

            } while (answer16 != guess);
          
            do
            {
                Console.WriteLine("What is the value of x in this code:  \n\nint x = 0;\nint a = 100;\nint b = 200;\nint c = 300;\nif (a != 100)\n{\n\tx += 1;\n}\nif (b != 200)\n{\n\tx += 2;\n}\nif (c != 300)\n{\n\tx += 3;\n}\nx = 7;");
                guess = Console.ReadLine();
                if (guess == answer17)
                {
                    Console.WriteLine("Correct!");
                    AddSpaces(1);
                }
                else
                {
                    Console.WriteLine("Try again");
                    wrongCount++;
                }
                Console.Clear();

            } while (answer17 != guess);
          
            do
            {
                Console.WriteLine("What is the value of x in this code: \n\nint x = 0;\nint a = 100;\nint b = 200;\nint c = 300;\nif (a != 100)\n{\n\tx += 1;\n}\nelse if (b != 200)\n{\n\tx += 2;\n}\nelse\n{\n\tx += 3;\n}");
                guess = Console.ReadLine();
                if (guess == answer18)
                {
                    Console.WriteLine("Correct!");
                    AddSpaces(1);
                }
                else
                {
                    Console.WriteLine("Try again");
                    wrongCount++;
                }
                Console.Clear();

            } while (answer18 != guess);
         
            do
            {
                Console.WriteLine("This expression uses the _______ operator: \n\n var answer = a > b ? 1000 : -1000;");
                guess = Console.ReadLine();
                if (guess == answer19)
                {
                    Console.WriteLine("Correct!");
                    AddSpaces(1);
                }
                else
                {
                    Console.WriteLine("Try again");
                    wrongCount++;
                }
                Console.Clear();

            } while (answer19 != guess);

            var time = sw.Elapsed.TotalSeconds;

            Console.WriteLine("Total seconds to complete:");
            Console.WriteLine(time);

            int score = (int)((time * .4) + (wrongCount * .6));

            Console.WriteLine("Your Score:");
            Console.WriteLine(score);
            Console.ReadLine();
        }

        public static void AddSpaces(int numberOfSpaces)
        {
            while (numberOfSpaces > 0)
            {
                Console.WriteLine();
                --numberOfSpaces;
            }
        }

    }
}

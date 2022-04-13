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

            Stopwatch sw = Stopwatch.StartNew();


            var answer = "if"; // The __ statement is the first form of Selection Statements
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

            var answer12 = "true"; // What is the value of x in this code: const string Name = "Jack"; switch (Name)
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

            var answer13 = "true"; // What is the value of message in this code:  var key =  Keyboard.Esc; switch (Console.ReadKey())
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

            var answer18 = "1"; // What is the value of x in this code: /* int x = 0;
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

            var answer19 = "3"; // var answer18 = "2"; // What is the value of x in this code: /* int x = 0;
                                    //                                         int a = 100;
                                    //                                         int b = 200;
                                    //                                         int c = 300;
                                    //                                         if (a != 100)
                                    //                                         {
                                    //                                              x += 1;
                                    //                                         }
                                    //                                         else if (b != 200)
                                    //                                         {
                                    //                                              x += 2;
                                    //                                         }
                                    //                                         else
                                    //                                         {
                                    //                                              x += 3;
                                    //                                         }*/

            var answer20 = "ternary"; // This expression uses the _______ operator: \t var answer = a > b ? 1000 : -1000;

            var wrongCount = 0;
            string guess;

            do
            {
                Console.WriteLine("The equal sign  `=`  is the _______ operator.");
                guess = Console.ReadLine();
                if (guess == answer)
                {
                    Console.WriteLine("Correct!");
                    AddSpaces(1);
                }
                else
                {
                    Console.WriteLine("Try again");
                    wrongCount++;
                }

            } while (answer1 != guess);

            do
            {
                Console.WriteLine("x += 20; What is the long form of this code?");
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

            } while (answer1 != guess);

            do
            {
                Console.WriteLine("x -= 1000; What is the long form of this code?");
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

            } while (answer2 != guess);

            do
            {
                Console.WriteLine("x *= 20; What is the long form of this code?");
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

            } while (answer3 != guess);

            do
            {
                Console.WriteLine("x /= 20; What is the long form of this code?");
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

            } while (answer4 != guess);

            do
            {
                Console.WriteLine("What is the % operator called?");
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

            } while (answer5 != guess);

            do
            {
                Console.WriteLine("x %= 20; What is the long form of this code?");
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

            } while (answer6 != guess);

            do
            {
                Console.WriteLine("x++; What is the long form of this code?");
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

            } while (answer7 != guess);

            do
            {
                Console.WriteLine("x--; What is the long form of this code?");
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

            } while (answer8 != guess);

            do
            {
                Console.WriteLine("++x; Is the ____ operator. (use a dash - between the first word [Example: pre-increment or post-increment])");
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

            } while (answer9 != guess);

            do
            {
                Console.WriteLine("x++; Is the ____ operator. (use a dash - between the first word Ex: pre-increment or post-increment)");
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

            } while (answer1 != guess);

            do
            {
                Console.WriteLine("int a = 1; and int b = 2; So what is the value of this expression: \t bool answer = a > b;");
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

            } while (answer1 != guess);

            do
            {
                Console.WriteLine("int a = 1; and int b = 2; So what is the value of this expression: \t bool answer = a < b;");
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

            } while (answer1 != guess);

            do
            {
                Console.WriteLine("int a = 0; and int b = 0; So what is the value of this expression: \t bool answer = a >= b;");
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

            } while (answer1 != guess);

            do
            {
                Console.WriteLine("int a = 1; and int b = 1; So what is the value of this expression: \t bool answer = a <= b;");
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

            } while (answer1 != guess);

            do
            {
                Console.WriteLine("int a = 1; and int b = 1; So what is the value of this expression: \t bool answer = a != b;");
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

            } while (answer1 != guess);

            do
            {
                Console.WriteLine("int a = 1; and int b = 2; So what is the value of this expression: \t bool answer = a == b;");
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

            } while (answer1 != guess);

            do
            {
                Console.WriteLine("int a = 1; and int b = 2; int c = 3; and int d = 4; So what is the value of this expression: \t bool answer = (a != b) && (c == d); ");
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

            } while (answer1 != guess);

            do
            {
                Console.WriteLine("int a = 1; and int b = 2; int c = 3; and int d = 4; So what is the value of this expression: \t bool answer = (a == b) || (c != d); ");
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

            } while (answer1 != guess);

            do
            {
                Console.WriteLine("int a = 1; and int b = 2; int c = 3; and int d = 4; So what is the value of this expression: \t bool answer = !(a == b) || (c == d);");
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

            } while (answer1 != guess);

            do
            {
                Console.WriteLine("This expression uses the _______ operator: \t");
                guess = Console.ReadLine();
                if (guess == answer20)
                {
                    Console.WriteLine("Correct!");
                    AddSpaces(1);
                }
                else
                {
                    Console.WriteLine("Try again");
                    wrongCount++;
                }

            } while (answer1 != guess);

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

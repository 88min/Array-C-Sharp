using System;

//@author 88min

namespace Array
{
    public class Program
    {
        static int[] array = new int[10]; //stores 10 user input to array
        static string store, retry;
        static int num1, num2, operation, result = 0, i = 0, show, ctr = 1;

        static void summary() //display summary of answers after 10 user input
        {

        do 
          {
                Console.Write("\n\n     <<< SUMMARY OF ANSWERS >>>\n");
                Console.WriteLine("\n       < ENTER CHOICE >\n\n     [1] Pick Result\n     [2] Print All Results\n");
                Console.Write("CHOICE: ");
                store = Console.ReadLine();
                show = Convert.ToInt32(store);

            if (show == 0 || show > 2) //invalid input
            {
                Console.WriteLine("\nINVALID INPUT, TRY AGAIN.");
            }  

            else if (show == 1) //pick an order in array to display
            {
                Console.WriteLine("\nYOU SELECTED [1] PICK RESULT");
                Console.Write("PLEASE CHOOSE RESULTS BETWEEN (1-10): ");
                store = Console.ReadLine();
                show = Convert.ToInt32(store);
         
                    switch (show) //display result of chosen order in array
                    {
                        case 1:
                            Console.Write("\n     RESULT NO. {0} = {1}\n", show, array[0]); //result is in the variable "show"
                      
                            break;
                        case 2:
                            Console.Write("\n     RESULT NO. {0} = {1}\n", show, array[1]);
                         
                            break;
                        case 3:
                            Console.Write("\n     RESULT NO. {0} = {1}\n", show, array[2]);
                        
                            break;
                        case 4:
                            Console.Write("\n     RESULT NO. {0} = {1}\n", show, array[3]);
                        
                            break;
                        case 5:
                            Console.Write("\n     RESULT NO. {0} = {1}\n", show, array[4]);
                           
                            break;
                        case 6:
                            Console.Write("\n     RESULT NO. {0} = {1}\n", show, array[5]);
                        
                            break;
                        case 7:
                            Console.Write("\n     RESULT NO. {0} = {1}\n", show, array[6]);
                          
                            break;
                        case 8:
                            Console.Write("\n     RESULT NO. {0} = {1}\n", show, array[7]);
                          
                            break;
                        case 9:
                            Console.Write("\n     RESULT NO.. {0} = {1}\n", show, array[8]);
                           
                            break;
                        case 10:
                            Console.Write("\n     RESULT NO. {0} = {1}\n", show, array[9]);
                          
                            break;
                        default:
                            Console.WriteLine("\nINVALID INPUT, TRY AGAIN.\n"); //invalid choice if not between 1-10
                            break;
                       }               
                }

            else if (show == 2) //display all result stored in array
            {
                Console.WriteLine("YOU SELECTED [2] PRINT ALL RESULTS\n");
                Console.Write("1.  {0}\n2.  {1}\n3.  {2}\n4.  {3}\n5.  {4}\n6.  {5}\n7.  {6}\n8.  {7}\n9.  {8}\n10. {9}\n", array[0], array[1], array[2], array[3], array[4], array[5], array[6], array[7], array[8], array[9]);
            }

            Console.WriteLine("\nDEAR USER, TRY ANOTHER CHOICE? \nEnter [Y] Yes , [N] No");  
            retry = Console.ReadLine();
            Console.WriteLine("\n=====================================");

                if (retry == "N" || retry == "n") //[N] end loop
            {
                Console.WriteLine("\nTHANK YOU FOR USING THE CALCULATOR.");
                Console.ReadKey();
            }
           
            } while (retry == "Y" || retry == "y"); //[Y] return to summary of answers, choice 1 and 2
        }

        static void solution() //arithmetic operations
        {
            do
            {
                Console.Write("\nFIRST INTEGER  : ");   //input 2 integers
                store = Console.ReadLine();
                num1 = Convert.ToInt32(store);
                Console.Write("SECOND INTEGER : ");
                store = Console.ReadLine();
                num2 = Convert.ToInt32(store);
                Console.Write("\n      < SELECT AN OPERATION >\n\n     [1] Addition\n     [2] Subtraction\n     [3] Multiplication\n     [4] Division\n     [5] Modulo\n\nCHOICE: ");
                store = Console.ReadLine();
                operation = Convert.ToInt32(store);
                show = 1;

                switch (operation)
                {
                    case 1:
                        Console.WriteLine("\nYOU SELECTED [1] ADDITION");
                        result = num1 + num2;   //addition
                        break;
                    case 2:
                        Console.WriteLine("\nYOU SELECTED [2] SUBTRACTION");
                        result = num1 - num2;   //subtraction
                        break;
                    case 3:
                        Console.WriteLine("\nYOU SELECTED [3] MULTIPLICATION");
                        result = num1 / num2;   //multiplication
                        break;
                    case 4:
                        Console.WriteLine("\nYOU SELECTED [4] DIVISION");
                        result = num1 * num2;   //division
                        break;
                    case 5:
                        Console.WriteLine("\nYOU SELECTED [5] MODULO");
                        result = num1 % num2;   //modulo
                        break;
                    default:
                        Console.WriteLine("\nINVALID INPUT, NO RESULT."); //invalid input is equivalent to 0
                        break;
                }

                Console.WriteLine("\n     RESULT NO. {0} = {1}", show, result);
                Console.WriteLine("\n=====================================");
                array[i] = result; //store in array until loop ends
                i++;
                show++; 
                ctr++;

            } while (ctr <= 1);
        }

        static void Main()
        {
            Console.WriteLine("\n============CALCULATOR=============");
            solution();
            summary();
            Console.ReadKey();
        }
    }
}


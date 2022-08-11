using System;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Dersde yazilan kodlar

            //try
            //{
            //    var a = Console.ReadLine();
            //    int b = int.Parse(a);
            //Console.WriteLine(b.GetType());
            //Console.WriteLine(a.GetType());
            //    Console.WriteLine(b + 5);

            //}
            //catch (FormatException)
            //{

            //    Console.WriteLine("sadece reqem daxil etmek mumkundur"); ;
            //}
            //finally
            //{
            //    Console.WriteLine("kodu duzelt");
            //}


            //bool y= int.TryParse("j", out int c);
            //if (y)
            //{
            //    Console.WriteLine(c.GetType());
            //}

            //string b = Console.ReadLine();
            //int c = Convert.ToInt32(b);
            //Console.WriteLine(c);   

            //int[] nums = new int[5] { 1, 2, 3, 4, 5 };
            //int[] nums2 = new int[5];
            //nums2[0] = 1;
            //nums2[1] = 2;   
            //nums2[2] = 3;
            //nums2[3] = 4;
            //nums2[4] = 5;
            //for (int i = 0; i < nums2.Length; i++)
            //{
            //    nums2[i] = i+1;

            //}
            //foreach (int b in nums2)
            //{
            //    Console.WriteLine(b);
            //}  



            //int[] numbers = { 1, 2, 3, 4, 5, 6 };
            //foreach (var item in numbers)
            //{
            //    Console.WriteLine(item);
            //}

            //char[] letter = { 's', 'b', 'c', 'd', 'e', 'f' };
            //foreach (var items in letter)
            //{
            //    Console.WriteLine(items);
            //}

            // int[,] numbers = { { 1, 2 }, { 3, 4 }, { 5, 6 } };   // multi dimension
            //foreach (var item in numbers)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine(numbers);

            //int[,,] numbers = { { { 1, 2 }, { 3, 4 } }, { { 5, 6 }, { 7, 8 } } };

            //int[,] numbers = { { 1, 2 }, { 3, 4 }, { 5, 6 } };   // multi dimension
            //Console.WriteLine(numbers[0,1]);//0 ci indeksin 1 ci indeksi 

            //int[] numbers = { 1, 2, 3, 4, 5, 6, };
            //Console.WriteLine(numbers[0]);


            //int[,] numbers = { { 1, 2 }, { 3, 4 }, { 5, 6 } };   // 6 ni deis 15 ele
            //numbers[2, 1] = 15;
            //foreach (int i in numbers)
            //{
            //    Console.WriteLine(i);   
            //}


            //string[] names = { "ANicat", "CTural", "BSolmaz" };
            //Array.Sort(names);
            //foreach (string name in names)
            //{
            //    Console.WriteLine(name);    
            //}



            //string[] names = { "Nicat", "Tural", "Solmaz" };
            //Array.Reverse(names);
            //foreach (string name in names)
            //{
            //    Console.WriteLine(name);
            //}

            //int[] a = { 1, 2, 6, 8, 19, 3, 7, 20, 5 };
            //for (int i = 0; i < a.Length; i++)
            //{
            //    if (a[i] == 20)
            //    {
            //        console.writeline(i);
            //    }
            //}
            //foreach (var item in a)
            //{
            //    if (item==20)
            //    {
            //        Console.WriteLine(item);
            //    }
            //20 ni tapmaq isdyrem. cox uzun reqem olsa burda hamisin
            //bir bir yoxlayib 20 ni axtaracaq  bigonotation addim sayi olcur
            //

            //int[,] nums  = { {1,2 }, {5,9 }, {14,19 } };
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    if (i ==2)
            //    {
            //        for (int j = 0; j < 2; j++)
            //        {
            //            Console.WriteLine(nums[i,j]);
            //        }
            //    }
            //}

            #endregion


            #region Task 1 -- Write a C# that calculates the day of week (ex: Monday) of your birthday
            //Console.WriteLine("Enter ur bday in format 10/22/1987");
            //string strBday = Console.ReadLine();
            //DateTime bday = DateTime.Parse(strBday);
            //Console.WriteLine(bday.DayOfWeek);
            #endregion

            #region Task 2 -- Write a C# that calculates you current life days (how many days past since your birth)

            //Console.WriteLine("Enter ur bday in format 10/22/1987 (mm/dd/yyyy)");
            //string strBday = Console.ReadLine();
            //DateTime bday = DateTime.Parse(strBday);
            //DateTime dt = DateTime.Now;
            //Console.WriteLine((dt - bday).Days);
            #endregion

            #region Task 3 -- Write a C# Sharp program to find the largest of three numbers.


            //string str1 = Console.ReadLine();
            //int a = int.Parse(str1);

            //string str2 = Console.ReadLine();
            //int b = int.Parse(str2);

            //string str3 = Console.ReadLine();
            //int c = int.Parse(str3);

            //if (a == b || a == c || b==c)
            //{
            //    Console.WriteLine("ferqli reqemler daxil edilmelidir");
            //}
            // else if (a==b && a==c && b==c)
            //{
            //    Console.WriteLine("ferqli reqemler daxil edilmelidir");
            //}

            //else if (a > b && a > c)
            //{
            //    Console.WriteLine("The 1st Number is the greatest among three");
            //}
            //else if (b > a && b > c)
            //{
            //    Console.WriteLine("The 2nd Number is the greatest among three");
            //}
            //else
            //{
            //    Console.WriteLine("The 3rd Number is the greatest among three");
            //}
            #endregion

            #region Task4 --Write a program in C# Sharp to read any day number in integer and display day name in the word.Test Data : 4 Expected Output : Thursday


            //string strNum = Console.ReadLine();
            //int intNum = int.Parse(strNum); 
            //switch (intNum)
            //{
            //    case 1:
            //        Console.WriteLine("Monday");
            //        break;
            //    case 2:
            //        Console.WriteLine("Tuesday");
            //        break;
            //    case 3:
            //        Console.WriteLine("Wednesday");
            //        break;
            //    case 4:
            //        Console.WriteLine("Thursday");
            //        break;
            //    case 5:
            //        Console.WriteLine("Friday");
            //        break;
            //    case 6:
            //        Console.WriteLine("Saturday");
            //        break;
            //    case 7:
            //        Console.WriteLine("Sunday");
            //        break;
            //}
            #endregion

            #region Task 5 --Write a program in C# Sharp which is a Menu-Driven Program to perform a simple calculation.

            //Console.WriteLine("Enter the first Integer");
            //string strNum1 = Console.ReadLine();    
            //int intNum1 = int.Parse(strNum1);
            //Console.WriteLine("Enter the second  Integer");
            //string strNum2 = Console.ReadLine();
            //int intNum2 = int.Parse(strNum2);
            //Console.WriteLine("Here are the options : ");
            //Console.WriteLine("1 - Addition.");
            //Console.WriteLine("2 - Substraction.");
            //Console.WriteLine("3 - Multiplication."); 
            //Console.WriteLine("4 - Division."); 
            //Console.WriteLine("5 - Exit.");
            //Console.WriteLine("Input your choice :");
            //string strChoice = Console.ReadLine();  
            //int choice = int.Parse(strChoice);  
            //switch (choice)
            //{
            //    case 1: Console.WriteLine("The Addition of "+ intNum1+ " and "+ intNum2 + " is : " + (intNum1 + intNum2));
            //        break;
            //        case 2: Console.WriteLine("The Substraction of " + intNum1 + " and " + intNum2 + " is : " + (intNum1 - intNum2));
            //        break;
            //    case 3: Console.WriteLine("The Multiplication of " + intNum1 + " and " + intNum2 + " is : " + (intNum1* intNum2));
            //        break;
            //    case 4: Console.WriteLine("The Division of " + intNum1 + " and " + intNum2 + " is : " + (intNum1 / intNum2));
            //        break;
            //    case 5: Console.WriteLine("Exited");
            //        break;


            #endregion

            #region Task 6 --Write a program in C# to check whether a number is a palindrome (visual simmetric) or not
            //Console.WriteLine("Input a number: ");
            //string strNum = Console.ReadLine();
            //int main = int.Parse(strNum);
            //int main2 = main;
            //int reversedNum = 0;
            //while (main > 0)
            //{
            //    int lastDigit = main % 10;
            //    reversedNum = reversedNum * 10 + lastDigit;
            //    main = (main - lastDigit) / 10;
            //}

            //if(reversedNum == main2)
            //{
            //    Console.WriteLine(main2 +" is a palindrome number.");
            //}
            //else
            //{
            //    Console.WriteLine(main2 + " is not  palindrome number.");

            //}
            #endregion

            #region Task 7 Write a program in C# to create a function to calculate the sum of the individual digits of a given number.

            //string strNum = Console.ReadLine();
            //int intNum = int.Parse(strNum);
            //int enteredNumber = intNum;
            //int counter = 0;
            //int lastdigit;
            //while (intNum > 0)
            //{
            //    lastdigit = intNum % 10;
            //    intNum = (intNum - lastdigit) / 10;
            //    counter += lastdigit;


            //}
            //Console.WriteLine($"The sum of the digits of the number {enteredNumber} is : {counter}");

            #endregion








        }


    }








    }
 

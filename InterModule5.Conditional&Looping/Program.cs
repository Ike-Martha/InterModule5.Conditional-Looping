using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalsAndLooping
{
    class Program
    {
        static void Main(string[] args)
        {
            //TestIf
            string fileName = @"C:\Windows\win.ini";
            if (File.Exists(fileName))
            {
                Console.WriteLine(fileName);
                Console.WriteLine("==================");
                Console.WriteLine(File.ReadAllText(fileName));

                }

            ////TestIf
            //     string fileName = @"C:\Windows\win.ini";
            //if (File.Exists(fileName))
            //    Console.WriteLine(File.ReadAllText(fileName));

            //TestIfElse
            Console.WriteLine(" Enter a nmber: ");
            string value = Console.ReadLine();
            int number = 0;
            if (int.TryParse(value, out number))
            {
                Console.WriteLine("You enterd a valid number");

            }
            else
            {
                Console.WriteLine("inalid input");
            }

            //TestNestedIf
            Console.WriteLine("Enter a number");
            string Value = Console.ReadLine();
            int number1 = 0;
            if (int.TryParse(Value, out number1))
            {
                if (number1 == 0)
                {
                    Console.WriteLine("Enter a number other than 0");
                }
                else
                {
                    Console.WriteLine("You entered a vaild number");
                }

            }
            else
            {
                Console.WriteLine("Invalid input");
            }



            //multiple Condition
            Console.WriteLine("Enter a drive letter");
            string drive = Console.ReadLine();

            if (!string.IsNullOrEmpty(drive))
            {
                DriveInfo info = new DriveInfo(drive);
                if (!info.IsReady)
                    Console.WriteLine("The drive isn't ready. perhaps it is not formatted");
                else if (info.DriveType != DriveType.Fixed)
                    Console.WriteLine("Please specify a hard drive:");
                else if (info.TotalFreeSpace < 1000000)
                    Console.WriteLine("not enough free space");
                else Console.WriteLine("{0} is acceptable.", drive);


            }

            //conditional Operator
            Random random = new Random();
            int count = random.Next(1, 100);
            int saveCount;

            //common if else pattern
            if (count == 47)
            {
                saveCount = 0;
            }
            else
            {
                saveCount = count;
            }
            //using the conditional operator to write the above code
          //  it consist of question and a colon
             saveCount = count == 47 ? 0 : count;
            // syntax
            // condition ? first_expression: second_expression

            //SingleCondition


            //Console.Write("Enter a drive letter: ");
            //string drive = Console.ReadLine();

            //if (!string.IsNullOrEmpty(drive))
            //{
            //    DriveInfo Info = new DriveInfo(drive);
            //    if (Info.DriveType == DriveType.CDRom)
            //        Console.WriteLine(" CDROM Drive");
            //    else if (Info.DriveType == DriveType.Fixed)
            //        Console.WriteLine("Hard Drive");
            //    else if (Info.DriveType == DriveType.Network)
            //        Console.WriteLine("Network Drive");
            //    else if (Info.DriveType == DriveType.Removable)
            //        Console.WriteLine("Removeable Drive");
            //    else if (Info.DriveType == DriveType.Unknown)
            //        Console.WriteLine("unknown drive type");
            //    else
            //        Console.WriteLine("what is up with this Drive");



            //    }

            //simplifying the above code using switch
            //Console.WriteLine("Enter a drive letter: ");
            //string drive = Console.ReadLine();
            //if(!string.IsNullOrEmpty(drive))
            //{
            //    DriveInfo info = new DriveInfo(drive);
            //    switch(info.DriveType) 
            //    {
            //        case DriveType.CDRom:
            //            Console.WriteLine("CDROM");
            //            break;
            //        case DriveType.Fixed:
            //            Console.WriteLine("Hard Driver");
            //            break;
            //        case DriveType.Network:
            //            Console.WriteLine("Network Drive");
            //            break;
            //        case DriveType.Removable:
            //            Console.WriteLine("Removal Drive");
            //            break;
            //        case DriveType.Unknown:
            //            Console.WriteLine("Unknown Drive Type");
            //            break;
            //        default:
            //            Console.WriteLine("What's up with this drive?");
            //            break;
            //    }
            //}

            //more switch
            //Console.WriteLine("Enter a number less than 21");
            //string Value = Console.ReadLine();
            //int number = 0;
            ////set a default value for the number type
            //string numberType = "Even";
            //if (int.TryParse(Value, out number))
            //{
            //    if (number > 20 || number < 0)
            //        Console.WriteLine("Number out of range");
            //    else
            //    {
            //        switch (number)
            //        {
            //            // this two cases fall through a common result
            //            case 0:
            //            case 1:
            //                Console.WriteLine("You entered 0 or 1");
            //                break;
            //            // all these cases fall through a common result
            //            case 2:
            //            case 3:
            //            case 5:
            //            case 7:
            //            case 11:
            //            case 13:
            //            case 17:
            //            case 19:
            //                Console.WriteLine("You enterd a small Prime number");
            //                break;
            //            // these cases fall through a common result, but they also jump to the next block. 
            //            //the code can't just fall through, because the block includes code
            //            case 9:
            //            case 15:
            //                numberType = "Odd";
            //                goto default;
            //            default:
            //                Console.WriteLine("You selected an {0} number", numberType);
            //                break;
            //        }
            //    }

            //}

            //Repeating code block and looping
           //simple While
            //while (true)
            //{
           //    Console.WriteLine("Enter a driver letter (press enter to quit):");

            //    string driveName = Console.ReadLine();
            //    if (string.IsNullOrEmpty(driveName))
            //    {
            //        break;
            //    }
            //    else
            //    {
            //        driveName = driveName.Substring(0, 1).ToUpper();
            //        if (string.Compare(driveName, "A") >= 0 &&
            //            string.Compare(driveName, "Z") <= 0)
            //        {
            //            DriveInfo info = new DriveInfo(driveName);
            //            if (info.IsReady)
            //            {
            //                Console.WriteLine($"Drive {driveName} has {info.TotalFreeSpace} byte free.");
            //            }
            //            else
            //            {
            //                Console.WriteLine($"Drive {driveName} isn't ready");

            //            }
            //        }
            //        else
            //        {
            //            Console.WriteLine($"Invalid drive letter {driveName}");
            //        }


            //    }
            //}

            //testWhile
            //    string driveName = "C";
            //    while(!string.IsNullOrEmpty(driveName))
            //    {
            //    Console.WriteLine("Enter a drive letter (press Enter to quit): ");
            //    driveName = Console.ReadLine();
            //    if(!string.IsNullOrEmpty(driveName))
            //    {
            //        driveName = driveName.Substring(0, 1).ToUpper();
            //        if(string.Compare(driveName,"A") >= 0 && string.Compare(driveName,"Z") <= 0)
            //        {
            //            DriveInfo info = new DriveInfo(driveName);
            //            if (info.IsReady)
            //            {
            //                Console.WriteLine($"Drive {driveName} has {info.TotalFreeSpace} byte free");
            //            }
            //            else
            //            {
            //                Console.WriteLine($"Drive {driveName} isn't ready");
            //            }
            //        }
            //    }
            //}

            //doWhile loop
            //int i = 10;
            ////this loop will never execute because i is already 10
            //while(i < 10)
            //{
            //    Console.WriteLine($"wont execute: i = {0}",i);
            //    i++;
            //}
            ////even though i is already 10, this code will execute once
            //do
            //{
            //    Console.WriteLine("this code will execute: i = {0}", i);
            //    i++;
            //} while (i < 10);


            //for loop
            //int j = 0;
            //while (j <= 10)
            //{
            //    Console.WriteLine($"Item {j}");
            //    j++;
            //}
            //Console.WriteLine();

            ////The same functionality as a for loop looks like this

            //for (int k = 0; k <= 10; k++) 
            //{
            //    Console.WriteLine($"Item {k}", k);
            //}

            //you can increment your loop by different values
            //by 2
            //for (int i = 0; i <= 10; i+=2)
            //{
            //    Console.Write($"{i} ");

            //}
            //Console.WriteLine();    
            ////by 3
            //for (int i = 0; i <= 10; i+=3)
            //{
            //    Console.Write($"{i}  ");
            //}
            //Console.WriteLine();

            ////by -1
            //for (int i = 10; i >= 0; i--)
            //{
            //    Console.Write($"{i}  ");
            //}

            //if you declare the looping variable outside the loop, what is it's value after the loop
            //int a = 0;
            //for(a = 5; a <= 10; a++)
            //{
            //    Console.Write($" {a}  ");
            //}
            //Console.WriteLine();
            //Console.WriteLine($" a is now: {a}  ");

            //nested for loop
            //for(int i = 1; i <= 10; i++)
            //{ 
            //    for(int j = 1; j <= 5; j++)
            //    {
            //        //display the product i * j padded to take four space
            //        Console.Write($"{i * j,5}");//don't understand
            //    }
            //    Console.WriteLine();
            //}

            //iterating thorugh a collection of object  ListDrives()
            //DriveInfo[] drives = DriveInfo.GetDrives();//initialise the array and call the method
            //for (int i = 0; i < drives.Length; i++)
            //{
            //    DriveInfo drive = drives[i];
            //    if (drive.IsReady)
            //    {
            //        Console.WriteLine($"Drive {drive.Name}: {drive.TotalFreeSpace} byte free");
            //    }
            //}

            //foreach(DriveInfo drive in DriveInfo.GetDrives())
            //{
            //    if(drive.IsReady)
            //    {
            //        Console.WriteLine($"Drive {drive.Name}: {drive.TotalFreeSpace} byte free");
            //    }
            //}


            //unconditional branching
            //existForeach
            //foreach(DriveInfo drive in DriveInfo.GetDrives())
            //{
            //    if(drive.IsReady)
            //    {
            //        Console.WriteLine($"drive {drive.Name}: {drive.TotalFreeSpace} byte free");

            //    }
            //    else
            //    {
            //        break;
            //    }
            //}


            //    //test Goto
            //    int value = 0;
            //    long sum = 0;
            //    System.Random rnd = new System.Random();
            //    for(int i = 1; i <= 1000; i++)
            //    {
            //        //do some work in here
            //        for(int j = 1; j <= 1000; j++)
            //        {
            //            //do some work in here
            //            for(int k = 1; k <= 1000; k++)
            //                value = rnd.Next(1, 1000);
            //            if(value == 357)
            //            {
            //                //if you get 357 you must quit
            //                goto ExitHere;
            //            }
            //            sum++;
            //        }
            //    }
            //ExitHere:
            //    Console.WriteLine("You go to {0}", sum);





        }
    }
}


using System;


namespace Lab2
{
    class Lab2
    {
        public static void Main()
        {
            Console.WriteLine("Lab2 Implementation" + "\n");
            //Creating variables
            bool validNum = true;
            int maxNumber = 0;
            int minNumber = 0;
            string numberEntered = "";
            int number;
            int totalOddNum = 0;
            double aveOddNum = 0.00D;
            int sumOddNum = 0;
            int totalEvenNum = 0;
            double aveEvenNum = 0.00D;
            int sumEvenNum = 0;
            string repeat = "";
            int firstAttempt = 0;
            bool playagain = false;
            bool assignMinMax = true;

            do
            {
                validNum = true;
                totalEvenNum = 0;
                sumOddNum = 0;
                aveEvenNum = 0;
                aveOddNum = 0;
                sumEvenNum = 0;
                totalEvenNum = 0;
                totalOddNum = 0;
                while (validNum)
                {
                    Console.Write("Enter an integer: ");
                    Console.Beep();

                    //Capture the user's response
                    numberEntered = Console.ReadLine();


                    // first attempt rejecting enter key
                    if (firstAttempt == 0 && string.IsNullOrWhiteSpace(numberEntered))
                    {
                        Console.WriteLine();
                        Console.WriteLine("You did not enter any integer ");
                        Console.WriteLine();
                        Console.Write("Play again (Y)? ");
                        repeat = Console.ReadLine();
                        Console.WriteLine();
                        if (repeat == "Y" || repeat == "y")
                        {

                            playagain = true;
                            validNum = false;
                        }
                        else
                        {
                            playagain = false;
                            Console.WriteLine("Thank you for play. Press Enter to finish.Press any key to continue . . .");
                            validNum = false;
                        }

                    }
                    else if (!string.IsNullOrWhiteSpace(numberEntered))
                    {
                        firstAttempt++;
                        // Convert from string to integer
                        validNum = int.TryParse(numberEntered, out number);

                        //assign a number to minumum and maximum values
                        if (assignMinMax)
                        {
                            minNumber = number;
                            maxNumber = number;
                            assignMinMax = false;
                        }
                        // Number of odd numbers
                        if (number % 2 != 0)
                        { totalOddNum++; }

                        // Sum of odd numbers
                        if (number % 2 != 0)
                        { sumOddNum += number; }

                        // Average number of odd numbers
                        if (number % 2 != 0)
                        { aveOddNum = (double)sumOddNum / totalOddNum; }

                        // Number of even numbers
                        if (number % 2 == 0)
                        { totalEvenNum++; }

                        // Sum of even numbers
                        if (number % 2 == 0)
                        { sumEvenNum += number; }

                        // Average number of even numbers
                        if (number % 2 == 0)
                        { aveEvenNum = (double)sumEvenNum / totalEvenNum; }

                        

                        if (number < minNumber)
                        { minNumber = number; }

                        if (number > maxNumber)
                        { maxNumber = number; }
                    }
                    else if (string.IsNullOrWhiteSpace(numberEntered))
                    { validNum = false;
                        Console.WriteLine("");
                        Console.WriteLine("The maximum integer you entered is: " + maxNumber);
                        Console.WriteLine("The minimum integer you entered is: " + minNumber + "\n");
                        Console.WriteLine("The number of odd interger(s) you entered is: " + totalOddNum);
                        Console.WriteLine("The sum of all odd interger(s) you entered is: " + sumOddNum);
                        Console.WriteLine("The average of all odd interger(s) you entered is " + aveOddNum + "\n");
                        Console.WriteLine("The number of even interger(s) you entered is: " + totalEvenNum);
                        Console.WriteLine("The sum of all even interger(s) you entered is: " + sumEvenNum);
                        Console.WriteLine("The average of all even interger(s) you entered is " + aveEvenNum + "\n");



                        Console.Write("Play again (Y)? ");
                        repeat = Console.ReadLine();
                        Console.WriteLine();
                        if (repeat == "Y" || repeat == "y")
                        {

                            playagain = true;
                            firstAttempt = 0;
                        }
                        else
                        {
                            playagain = false;
                            Console.WriteLine("Thank you for play. Press Enter to finish. Press any key to continue . . .");
                            validNum = false;
                        }
                    }
                }
               

            } while (playagain);




            // Allows us to read what was displayed
            Console.Read();
            } // End of main
        } // End of class
    } // End of namespace

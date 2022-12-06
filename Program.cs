using System;
using System.Threading;

namespace ATMSOFTWARE { 
    class atmDetails { 

        public double cardNumber = 1234567890123456; 
        public int cardPin = 2022;
        public double amount = 1000; 
        public double balance = 10000; 
        public int restBalance = 10000; 

        static void Main(string[] args) { 
            Console.WriteLine("---------------- ATM SOFTWARE ----------------"); 
            Thread.Sleep(5000); 
            Console.Clear(); 

            atmDetails details = new atmDetails(); 

            Console.WriteLine("Insert your card number: "); 
            var insertedCard = Convert.ToDouble(Console.ReadLine()); 

            if(insertedCard == details.cardNumber) { 
                Console.WriteLine("Insert your pin: "); 
                var insertedPin = Convert.ToInt32(Console.ReadLine()); 

                if(insertedPin == details.cardPin) { 
                    Console.WriteLine("You logged in your account!"); 
                    Thread.Sleep(3000); 
                    Console.Clear(); 

                    Console.WriteLine("1. Balance"); 
                    Console.WriteLine("2. Withdraw"); 
                    Console.WriteLine("3. Account details \n"); 
                    Console.WriteLine("Choose an option: ");

                    var userChoice = Convert.ToInt64(Console.ReadLine()); 
                    double balanceMoneyLocal = 10000;

                    switch (userChoice) { 
                        case 1: 
                            Console.Clear();
                            Console.WriteLine($"Your balance is: ${details.balance}"); 
                            break; 

                        case 2:
                            Console.Clear();
                            Console.WriteLine($"How much you want to withdraw? \n"); 
                            var amountToWithdraw = Convert.ToDouble(Console.ReadLine()); 

                            if (amountToWithdraw >= details.amount) { 
                                Console.WriteLine("Sorry! Your amount is greater than our limit! Try again! \n Remember our limit is 1000$");
                                Console.WriteLine("Wait 10 seconds if you want to try to again!"); 
                                Thread.Sleep(10000); 
                                
                                    for(int i = 10; i < 0; i--) { 
                                        Console.WriteLine(i); 
                                    }
                                
                                Console.WriteLine("Try again? y/n"); 
                                var userSecondChoice = Convert.ToString(Console.ReadLine()); 
                                    if (userSecondChoice == "y") { 
                                        Console.WriteLine($"How much you want to withdraw? \n"); 
                                        var secondAmountToWithdraw = Convert.ToDouble(Console.ReadLine()); 

                                            if (secondAmountToWithdraw <= details.amount) { 
                                                Console.WriteLine($"Nice! You withdrawed ${secondAmountToWithdraw}!"); 
                                                int moneyRest = (int)(balanceMoneyLocal - secondAmountToWithdraw); 
                                            } else { 
                                                break; 
                                            }
                                    }
                                
                            } else { 
                                Console.Clear();
                                Console.WriteLine($"Nice! You withdrawed ${amountToWithdraw}!"); 
                                int moneyRest = (int)(balanceMoneyLocal - amountToWithdraw); 
                                Console.Write($"The rest of your money is: {moneyRest}");
                            }

                            break;

                        case 3: 
                            Console.Clear();
                            Console.WriteLine($"Your account details: \n Card number: {details.cardNumber} \n Card pin: {details.cardPin}");

                            break; 
                    }
                }
            }
        }
    }
}
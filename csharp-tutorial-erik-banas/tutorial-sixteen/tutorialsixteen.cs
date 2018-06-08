using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace tutorial_16
{
    //Threads
    class TutorialSixteen
    {
        //static void Main()
        //{
        //    Thread t = new Thread(Print1);
            
        //    t.Start();

        //    {
        //        for (int i = 0; i < 1000; i++)
        //            Console.Write(0);
        //    }

        //    Console.ReadLine();
        //}
        ////static void Main()
        ////{
        ////    BankAccct acct = new BankAccct(10);
        ////    Thread[] threads = new Thread[15];

        ////    Thread.CurrentThread.Name = "main";

        ////    for( int i= 0; i< 15; i++)
        ////    {
        ////        Thread t = new Thread(new ThreadStart
        ////            (acct.IssueWithdraw));
        ////        t.Name = i.ToString();
        ////        threads[i] = t;
        ////    }
        ////    for (int i = 0; i < 15; i++)
        ////    {
        ////        Console.WriteLine("Thread {0} Alive : {1}",
        //            threads[i].Name,
        //            threads[i].IsAlive);
        //        threads[i].Start();

        //        //priority of the thread
        //        Console.WriteLine("Current Priority ; {0}",
        //            Thread.CurrentThread.Priority);

        //        Console.WriteLine("Thread {0} Ending",
        //            Thread.CurrentThread.Name);
        //    }

        //    Console.ReadLine();
        //}

            static void Main()
        {
            Thread t = new Thread(()=> CountTo(10));
            t.Start();

            new Thread(() =>
            {
                CountTo(5);
                CountTo(6);
            }).Start();

            Console.ReadLine();
        }

            class BankAccct
        {
            private Object acctlock = new object();
            double Balance { set; get; }

            public BankAccct(double bal)
            {
                Balance = bal;
            }

            public double Withdraw(double amt)
            {
                if((Balance - amt) <0 )
                    {
                    Console.WriteLine($"Sorry ${Balance} in Account");
                    return Balance;
                }

                lock(acctlock)
                {
                    if(Balance >= amt)
                    {
                        Console.WriteLine("Removed {0} and {1} left in account",
                            amt, (Balance-amt));
                        Balance -=amt;
                    }
                    return Balance;
                }
            }

            public void IssueWithdraw()
            {
                Withdraw(1);
            }
        }
        //    static void Main()
        //{
        //    int num = 1;

        //    for(int i = 0; i < 10; i++)
        //    {
        //        Console.WriteLine(num);
        //        Thread.Sleep(1000);//sleep for a second
        //        num++;
        //    }
        //    Console.WriteLine("Thread ends");
        //    Console.ReadLine();
        //}

        //static void Print1()
        //{
        //    for (int i = 0; i < 1000; i++)
        //        Console.Write(1);
        //}

        static void CountTo(int maxNum)
        {
            for(int i =0; i<= maxNum; i++)
            {
                Console.WriteLine(i);
            }
        }
    }//end of class

}//end of namespace

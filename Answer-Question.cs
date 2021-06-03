using System;

namespace game
{
    class Program
    {
        enum Difficulty
        {
            Easy ,
            Normal,
            Hard  
        }

        static void Main(string[] args)
        {
            double userpoint = 0.00;
            userpoint = Math.Round(userpoint, 2);
            Difficulty x = Difficulty.Easy;
            int numprob = 0;
            int menu = 3;
            int key = 1;
            int num=0;

            Console.WriteLine("Score : {0} , Difficulty : {1} ", userpoint, x);

            while (key == 1)
            {                                        

                while (menu != 1 && menu != 0 || menu == 3)
                {
                  
                    Console.WriteLine("");

                    Console.WriteLine("Insert where you want to go " +
                        " 0 = Play game ," +
                        " 1 = Setting ," +
                        " 2 = Quit game");

                    Console.WriteLine();

                    Console.Write("command : ");

                    menu = int.Parse(Console.ReadLine());

                    Console.WriteLine();


                    if (menu == 2)
                    {
                        key = 2;
                        Console.WriteLine("Thank you for using ");
                        return;
                    }
                    else if (menu < 0 || menu > 2)
                    {
                        Console.WriteLine("Invaild number input, please RE-Enter it");

                        Console.WriteLine();

                    }
                }

                while (menu == 1)
                {
                    if (menu == 1)
                    {
                        

                        Console.WriteLine("Insert Your difficulty " +
                            "0 = Easy ," +
                            "1 = Normal ," +
                            "2 = Hard ");

                        Console.WriteLine(" ");

                        Console.Write("Command : ");
                        num = int.Parse(Console.ReadLine());

                        Console.WriteLine(" ");

                        if (num == 0)
                        {
                            x = Difficulty.Easy;
                            menu = 3;
                        }
                        if (num == 1)
                        {
                            x = Difficulty.Normal;
                            menu = 3;
                        }
                        if (num == 2)
                        {
                            x = Difficulty.Hard;
                            menu = 3;
                        }
                        else if (num < 0 || num > 2)
                        {
                            Console.WriteLine("Invaild number input, please RE-Enter it");

                            Console.WriteLine(" ");
                        }
                        Console.WriteLine("Current Difficulty : {0} ", x);              
                    }
                }                         
                while (menu == 0)
                {
                    if (menu == 0)
                    {
                        if (x == Difficulty.Easy)
                        {
                            numprob = 3;
                        }
                        if ( x == Difficulty.Normal)
                        {
                            numprob = 5;                            
                        }
                        if ( x == Difficulty.Hard)
                        {
                            numprob = 7;                          
                        }

                        GenerateRandomProblems(numprob);
                        
                        Problem[] problem = GenerateRandomProblems(numprob);

                        long second1 = DateTimeOffset.Now.ToUnixTimeSeconds();

                        int correct = 0;

                        for (int y = 0; y < numprob; y++)
                        {

                            Console.Write(problem[y].Message);                          
                            
                            int answer = 0;
                            answer = int.Parse(Console.ReadLine());

                            Console.WriteLine(" ");

                            if (answer == problem[y].Answer)
                            {
                               correct = correct + 1;

                            }
                            menu = 1;                         
                        }
                        long second2 = DateTimeOffset.Now.ToUnixTimeSeconds();

                        long second3 = second2 - second1;
                        int second = Convert.ToInt32(second3);

                        Console.WriteLine("Time estimate : {0} ", second);

                        Console.WriteLine(" ");

                        double qcqa = (double)correct / numprob;

                        qcqa = Math.Round(qcqa, 2);                       

                        double d = 25 - Math.Pow(num, 2);

                        double dd = Math.Max(second, d);

                        d = (double) d / dd;

                        d = Math.Round(d, 2);

                        double ddd = 2 * num + 1; 

                        ddd = Math.Pow(ddd, 2);

                        userpoint = qcqa * d * ddd;

                        Console.WriteLine("Score : {0} , Difficulty : {1} ", userpoint, x);

                        Console.WriteLine(" ");
                    }                 
                }
            }
                Console.ReadLine();          
        }
        struct Problem
        {
            public string Message;
            public int Answer;

            public Problem(string message, int answer)
            {
                Message = message;
                Answer = answer;
            }
        }             

        static Problem[] GenerateRandomProblems(int numProblem)
        {
            Problem[] randomProblems = new Problem[numProblem];

            Random rnd = new Random();
            int x, y;
         
            for (int i = 0; i < numProblem; i++)
            {
                x = rnd.Next(50); 
                y = rnd.Next(50);
                if (rnd.NextDouble() >= 0.5)
                    randomProblems[i] =
                    new Problem(String.Format("{0} + {1} = ", x, y), x + y);
                else
                    randomProblems[i] =
                    new Problem(String.Format("{0} - {1} = ", x, y), x - y);
            }          
            return randomProblems;
        }
    }
}

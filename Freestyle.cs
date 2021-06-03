using System;

namespace Dota_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Dota helper Version 1.0! ");

            string command = "1";
            double ver = 0.1;
            string side = "1";         
            
            Console.WriteLine(" ");

            Console.WriteLine("type help for information you want to know");

            Console.WriteLine(" ");

            while (command != "exit")
            {
                Console.Write("what you want to know : ");

                command = Console.ReadLine(); 


                if (command == "help")
                {
                    Console.WriteLine("");

                    Console.WriteLine("Current version of this helper is {0} ", ver);

                    Console.WriteLine("");

                    Console.WriteLine("Function provided : ");

                    System.Threading.Thread.Sleep(700);

                    Console.WriteLine("Roshan calculating --> type rs");

                    Console.WriteLine("");

                    System.Threading.Thread.Sleep(700);

                    Console.WriteLine("Basic pull creep wave --> type pull");

                    Console.WriteLine("");

                    System.Threading.Thread.Sleep(700);

                    Console.WriteLine("Basic KDA calculating --> type kda");

                    Console.WriteLine("");

                    System.Threading.Thread.Sleep(700);

                    Console.WriteLine("MMR to medal calculating --> type mmr");

                    Console.WriteLine(" ");

                    System.Threading.Thread.Sleep(700);

                    Console.WriteLine("If you want to quit the program --> type exit");

                    Console.WriteLine("");
                }

                if (command == "mmr" || command == "MMR")
                {
                    int mmr = 0;
                   while (mmr <= 0)
                    {
                        Console.WriteLine(" ");

                        Console.Write("Input your MMR : ");

                        mmr = int.Parse(Console.ReadLine());

                        Console.WriteLine(" ");
                        
                        if (mmr <= 0)
                        {
                            Console.WriteLine(" ");

                            Console.WriteLine("Invaild mmr please Re-Enter it : ");
                        }

                        if (mmr >=1 && mmr <= 153)
                        {
                            Console.WriteLine("Your mmr is herald 1  ");
                        }
                        if (mmr >= 154 && mmr <= 307)
                        {
                            Console.WriteLine("Your mmr is herald 2  ");
                        }
                        if (mmr >= 308 && mmr <= 461)
                        {
                            Console.WriteLine("Your mmr is herald 3  ");
                        }
                        if (mmr >= 462 && mmr <= 615)
                        {
                            Console.WriteLine("Your mmr is herald 4  ");
                        }
                        if (mmr >= 616 && mmr <= 769)
                        {
                            Console.WriteLine("Your mmr is herald 5  ");
                        }
                        if (mmr >= 770 && mmr <= 923)
                        {
                            Console.WriteLine("Your mmr is guardian 1  ");
                        }                                  
                                                             
                        if (mmr >= 924 && mmr <= 1077)        
                        {                                  
                            Console.WriteLine("Your mmr is guardian; 2  ");
                        }                                  
                        if (mmr >= 1078 && mmr <= 1231)        
                        {                                  
                            Console.WriteLine("Your mmr is guardian; 3  ");
                        }                                  
                        if (mmr >= 1232 && mmr <= 1385)        
                        {                                  
                            Console.WriteLine("Your mmr is guardian; 4  ");
                        }
                        if (mmr >= 1386 && mmr <= 1539)
                        {
                            Console.WriteLine("Your mmr is guardian 5  ");
                        }
                        if (mmr >= 1540 && mmr <= 1693)
                        {
                            Console.WriteLine("Your mmr is crusader 1  ");
                        }                                  
                        if (mmr >= 1694 && mmr <= 1847)        
                        {                                  
                            Console.WriteLine("Your mmr is crusader 2  ");
                        }                                 
                        if (mmr >= 1848 && mmr <= 2001)       
                        {                                 
                            Console.WriteLine("Your mmr is crusader 3  ");
                        }                                 
                        if (mmr >= 2002 && mmr <= 2155)       
                        {                                 
                            Console.WriteLine("Your mmr is crusader 4  ");
                        }                                  
                        if (mmr >= 2156 && mmr <= 2309)    
                        {                                  
                            Console.WriteLine("Your mmr is crusader 5  ");
                        }
                        if (mmr >= 2310 && mmr <= 2463)
                        {
                            Console.WriteLine("Your mmr is archon 1  ");
                        }
                        if (mmr >= 2464 && mmr <= 2617)
                        {
                            Console.WriteLine("Your mmr is archon 2  ");
                        }
                        if (mmr >= 2618 && mmr <= 2771)
                        {
                            Console.WriteLine("Your mmr is archon 3  ");
                        }
                        if (mmr >= 2772 && mmr <= 2925)
                        {
                            Console.WriteLine("Your mmr is archon 4  ");
                        }
                        if (mmr >= 2926 && mmr <= 3079)
                        {
                            Console.WriteLine("Your mmr is archon 5  ");
                        }
                        if (mmr >= 3080 && mmr <= 3233)
                        {
                            Console.WriteLine("Your mmr is legend 1  ");
                        }
                        if (mmr >= 3234 && mmr <= 3387)
                        {
                            Console.WriteLine("Your mmr is legend 2  ");
                        }
                        if (mmr >= 3388 && mmr <= 3541)
                        {
                            Console.WriteLine("Your mmr is legend 3  ");
                        }
                        if (mmr >= 3542 && mmr <= 3695)
                        {
                            Console.WriteLine("Your mmr is legend 4  ");
                        }
                        if (mmr >= 3696 && mmr <= 3849)
                        {
                            Console.WriteLine("Your mmr is legend 5  ");
                        }
                        if (mmr >= 3850 && mmr <= 4003)
                        {
                            Console.WriteLine("Your mmr is ancient 1 ");
                        }
                        if (mmr >= 4004 && mmr <= 4157)
                        {
                            Console.WriteLine("Your mmr is ancient 2 ");
                        }
                        if (mmr >= 4158 && mmr <= 4311)
                        {
                            Console.WriteLine("Your mmr is ancient 3 ");
                        }
                        if (mmr >= 4312 && mmr <= 4465)
                        {
                            Console.WriteLine("Your mmr is ancient 4 ");
                        }
                        if (mmr >= 4466 && mmr <= 4619)
                        {
                            Console.WriteLine("Your mmr is ancient 5 ");
                        }
                        if (mmr >= 4620 && mmr <= 4819)
                        {
                            Console.WriteLine("Your mmr is divine 1  ");
                        }
                        if (mmr >= 4820 && mmr <= 5019)
                        {
                            Console.WriteLine("Your mmr is divine 2  ");
                        }
                        if (mmr >= 5020 && mmr <= 5219)
                        {
                            Console.WriteLine("Your mmr is divine 3  ");
                        }
                        if (mmr >= 5220 && mmr <= 5419)
                        {
                            Console.WriteLine("Your mmr is divine 4  ");
                        }
                        if (mmr >= 5420 && mmr <= 5619)
                        {
                            Console.WriteLine("Your mmr is divine 5  ");
                        }
                        if (mmr >= 5620)
                        {
                            Console.WriteLine("Your mmr is Immortal ");
                        }

                    }                                     
                }
                if (command == "exit")
                {
                    Console.WriteLine(" ");

                    Console.WriteLine("Thanks you for using our Dota2 helper ");

                    Console.WriteLine(" ");

                    System.Threading.Thread.Sleep(1000);

                    Console.WriteLine("Program will exit in ");

                    System.Threading.Thread.Sleep(1000);

                    Console.WriteLine("3");

                    System.Threading.Thread.Sleep(1000);

                    Console.WriteLine("2");

                    System.Threading.Thread.Sleep(1000);

                    Console.WriteLine("1");

                    System.Threading.Thread.Sleep(1000);

                    return;
                }

                if (command == "KDA" || command == "kda")
                {
                    int kill = 0, death = 0, assit = 0;
                    while (kill <= 0)
                    {
                        Console.WriteLine(" ");

                        Console.Write("Input kill : ");

                        kill = int.Parse(Console.ReadLine());

                        if (kill <= 00.00)
                        {
                            Console.WriteLine(" ");

                            Console.WriteLine("Invaild kill number please Re-Enter it : ");
                        }
                    }
                    while (death <= 0)
                    {
                        Console.WriteLine(" ");

                        Console.Write("Input death : ");

                        death = int.Parse(Console.ReadLine());

                        if (death <= 00.00)
                        {
                            Console.WriteLine(" ");

                            Console.WriteLine("Invaild death number please Re-Enter it : ");
                        }

                    }
                    while (assit <= 0)
                    {
                        Console.WriteLine(" ");

                        Console.Write("Input assit : ");

                        assit = int.Parse(Console.ReadLine());

                        if (assit <= 00.00)
                        {
                            Console.WriteLine(" ");

                            Console.WriteLine("Invaild assit number please Re-Enter it : ");
                        }
                    }

                    double ka = kill + assit;
                    double kda = ka / death;
                    kda = Math.Round(kda,2);
                    Console.WriteLine("");

                    Console.WriteLine("Your kda : {0} ", kda);

                    Console.WriteLine("");                   
                }

                if (command == "rs")
                {
                    double rstime = 00.00;
                    int rsnum = 0;

                    while (rstime <= 00.00)
                    {

                        Console.WriteLine(" ");

                        Console.Write("Input roshan dead time : ");

                        rstime = double.Parse(Console.ReadLine());

                        if (rstime <= 00.00)
                        {
                            Console.WriteLine(" ");

                            Console.WriteLine("Invaild number roshan time please Re-Enter it : ");
                        }
                    }                     
                    while (rsnum <= 0)
                    {
                        Console.WriteLine(" ");

                        Console.Write("Number of roshan : ");

                        rsnum = int.Parse(Console.ReadLine());

                        if (rsnum <= 0)
                        {
                            Console.WriteLine(" ");

                            Console.WriteLine("Invaild number roshan please Re-Enter it ");
                        }
                    }                                                            
                        double rstime1 = Math.Floor(rstime);                   

                        double rstimedivide = rstime - rstime1;

                        if (rstimedivide >= 0.60 || rstime <= 0.99)
                        {
                            rstimedivide = rstimedivide - 0.60;

                            rstime = rstime1 + 1;

                            rstime = rstime + rstimedivide;

                        }

                        if (rsnum == 2)
                        {
                            Console.WriteLine(" ");

                            Console.WriteLine("This roshan have aghanim shard don't forget to pick it up ");

                            System.Threading.Thread.Sleep(500);
                        }

                        if (rsnum == 3)
                        {
                            Console.WriteLine(" ");

                            Console.WriteLine("This roshan have refresher shard or aghanim don't forget to pick it up ");

                            System.Threading.Thread.Sleep(1000);
                        
                        }

                        double rstimeagis = rstime + 05.00;

                        rstimeagis = Math.Round(rstimeagis, 2);

                        Console.WriteLine(" ");

                        Console.WriteLine("Agis of immortality will expired at {0} ", rstimeagis);

                        Console.WriteLine(" ");

                        System.Threading.Thread.Sleep(500);

                        double rstimerespawn = rstime + 08.00;

                        rstimerespawn = Math.Round(rstimerespawn, 2);

                        Console.WriteLine("Roshan will start respawn at {0} ", rstimerespawn);

                        System.Threading.Thread.Sleep(500);

                        double rstimerespawn1 = rstime + 11.00;

                        rstimerespawn1 = Math.Round(rstimerespawn1, 2);

                        Console.WriteLine("");

                        Console.WriteLine("Roshan will guarantee respawn at {0} ", rstimerespawn1);

                        Console.WriteLine(" ");

                        string yn = "1";

                        while (yn != "N")
                        {
                            Console.Write("Do you want to know predict random time of roshan will be respawn at? (Y/N) : ");

                            yn = Console.ReadLine();

                            if (yn == "N" || yn == "n")
                            {
                                Console.WriteLine(" ");

                                break;
                            }
                            if (yn != "N" && yn != "n" && yn != "y" && yn != "Y")
                            {
                                Console.WriteLine(" ");

                                Console.WriteLine("Vaild input please re-input again ");

                            Console.WriteLine(" ");
                        }
                            if (yn == "Y" || yn == "y")
                            {
                                Console.WriteLine(" ");

                                Console.WriteLine("Your roshan will start respawn at {0} and guarantee at {1} ", rstimerespawn, rstimerespawn1);

                                System.Threading.Thread.Sleep(500);

                                Console.WriteLine("Sytem working....");

                                Console.WriteLine(" ");

                                System.Threading.Thread.Sleep(500);

                                Random rs = new Random();

                                int rsmin = rs.Next(0, 3);
                                double rssecond = rs.Next(0, 60);
                                rssecond = rssecond / 100;

                                double rstimesum = rsmin + rssecond;
                                rstimerespawn = rstimerespawn + rstimesum;

                                rstimerespawn = Math.Round(rstimerespawn, 2);

                                rstimerespawn1 = Math.Floor(rstimerespawn);

                                double rstimerespawn2 = rstimerespawn - rstimerespawn1;

                                if (rstimerespawn2 >= 00.60 && rstimerespawn2 <= 00.99)
                                {

                                    rstimerespawn2 = rstimerespawn2 - 00.60;

                                    rstimerespawn1 = rstimerespawn1 + 1;

                                    rstimerespawn = rstimerespawn1 + rstimerespawn2;

                                    rstimerespawn = Math.Round(rstimerespawn,2);
                                }

                                Console.WriteLine("We think that roshan will be spawn at : {0} ", rstimerespawn);

                                Console.WriteLine(" ");

                                break;
                            }

                        }
                    
                }
                
                if (command == "pull")
                {
                    while (side != "radiant" && side != "dire")
                    {
                        Console.WriteLine(" ");

                        Console.Write("Choose your side : ");
                        side = Console.ReadLine();

                        if (side != "radiant" && side != "dire")
                        {
                            Console.WriteLine(" ");

                            Console.WriteLine("Invaild side input please RE-Enter it again ");
                        }

                        if (side == "radiant" || side == "dire")
                        {
                            Console.WriteLine(" ");

                            Console.WriteLine("Current side : {0} ", side);

                            break;
                        }
                    }
                    Console.WriteLine(" ");
                    
                    string herotype = "1";
                    while (herotype != "melee" && herotype != "range")
                    {
                        Console.Write("What kind of hero you play? (melee/range) :");

                        herotype = Console.ReadLine();

                        Console.WriteLine(" ");

                        if (herotype != "melee" && herotype != "range")
                        {
                            Console.WriteLine("Invaild hero type , please re-enter value");

                            Console.WriteLine(" ");
                        }
                    }
                        string creeptype = "1";
                    while (creeptype != "jungle" && creeptype != "lane")
                    {
                        Console.Write("which creep type you want to pull? (lane/jungle) : ");

                        creeptype = Console.ReadLine();

                        Console.WriteLine(" ");

                        if (creeptype != "jungle" && creeptype != "lane")
                        {
                            Console.WriteLine("Invaild creep type , please re-enter value");

                            Console.WriteLine(" ");
                        }
                    }    
                        
                            if (creeptype == "jungle")
                            {
                                string jungletype = "1";
                                while (jungletype != "small" && jungletype != "medium " && jungletype != "large")
                                {
                                    Console.Write("Which camp do you want to pull? : ");

                                    jungletype = Console.ReadLine();

                                    if (jungletype != "small" && jungletype != "medium " && jungletype != "large")
                                    {
                                        Console.WriteLine(" ");

                                        Console.WriteLine("Invaild jungle creep type , please re-enter value");

                                        Console.WriteLine(" ");
                                    }
                                }
                            }

                                if (herotype == "range" && side == "dire" && creeptype == "lane")
                                {
                                    Console.WriteLine("You should pull top lane at small camp on 16 or 46");

                                    Console.WriteLine("");

                                    System.Threading.Thread.Sleep(2000);

                                    Console.WriteLine("If on bot lane you should pull large camp on 44-46");

                                    Console.WriteLine(" ");

                                    System.Threading.Thread.Sleep(2000);

                                    Console.WriteLine("Tips : on toplane you can use queling blade to cut down tree. that'll allow you to pull big camp at the same time");

                                    Console.WriteLine(" ");
                                }

                                if (herotype == "range" && side == "radiant" && creeptype == "lane")
                                {
                                    Console.WriteLine("Bot lane you should pull small camp on 17-18 or 47-48");

                                    Console.WriteLine(" ");

                                    System.Threading.Thread.Sleep(2000);

                                    Console.WriteLine("Tips  you can use queling blade to cut down tree. that'll allow you to pull at 53 and lure jungle creep past through the tree and it'll stack");

                                    Console.WriteLine(" ");
                                }                                    
                }           
            }
                                    Console.ReadLine();
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextMilitaryGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Boolean Begin = false;
            Boolean win = false;
            Boolean allianceChoose = false;
            Boolean decision;
            String country;
            String alliance;
            String answer;
            String Enemy;
            int str = 0;
            int def = 0;
            int money = 0;
            int soldiers = 0;
            int soldierRate = 0;
            int HP = 100000;
            int HPNPC = 100000;
            int strNPC = 0;
            int defNPC = 0;
            double target;
            double loanrate;
            
            //Setting Country
            do
            {
                Console.WriteLine("Welcome to the Military Strategy Game v0.1 please enter your country's name.");
                country = Console.ReadLine();
                Console.Clear();
                Console.WriteLine("Are you sure you want " + country + " as your country? (Yes or No)");
                answer = Console.ReadLine().ToLowerInvariant();
                if (answer == "yes") 
                Begin = true;
                else if (answer == "no")
                {
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("I'm sorry I didn't understand that.");
                    Console.Clear();
                }
            } while (Begin == false);
            
            Console.WriteLine("Welcome to the world " + country + ".");
            Console.WriteLine("Please select what alliance to join.");
            Console.WriteLine();
            Console.WriteLine("AXIS Attackers (Japan, Germany, Russia, Italy, Switzerland) [Offense]");
            Console.WriteLine("Allied Forces (USA, Canada, Europe, Mexico) [Defense]");
            Console.WriteLine("Go alone (FOR EXPERIENCED PLAYERS ONLY!)");
            Console.WriteLine("To join the AXIS Attackers type 'AXIS'");
            Console.WriteLine("To join the Allied Forces type 'Allied'");
            Console.WriteLine("To go alone type 'Alone'");
            alliance = Console.ReadLine();
                
            //Setting stats from allies
            do
            {
                decision = false;
                if (alliance == "AXIS")
                {
                    str = 2;
                    def = 1;
                    soldierRate = 5000;
                    money = 100000;
                    strNPC = 1;
                    defNPC = 2;
                    allianceChoose = true;
                    Console.WriteLine("You are now a part of the AXIS Attackers");
                }
                if (alliance == "Allied")
                {
                    str = 1;
                    def = 2;
                    soldierRate = 2500;
                    money = 200000;
                    strNPC = 2;
                    defNPC = 1;
                    allianceChoose = true;
                    Console.WriteLine("You are now a part of the Allied Forces");
                }
                if (alliance == "Alone")
                {
                    str = 1;
                    def = 1;
                    soldierRate = 1000;
                    money = 75000;
                    strNPC = 3;
                    defNPC = 3;
                    allianceChoose = true;
                    Console.WriteLine("You have decided to go alone.");
                }
                Console.WriteLine("Is this what you want? (Yes or No)");
                answer = Console.ReadLine().ToLowerInvariant();
                if (answer == "yes")
                    decision = true;
                else if (answer == "no")
                {
                    decision = false;
                    alliance = "";
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("I'm sorry I didn't understand that.");
                    decision = false;
                    alliance = "";
                    Console.Clear();
                }
            } while (decision == false && allianceChoose == false) ;
            
            //Story
            Console.Clear();
            Console.WriteLine("Welcome " + country +"! The year is 1415... Our world is on the verge of a massive war over a new alien technology... Press enter to continue.");
            Console.ReadLine();
            Console.WriteLine("The AXIS Attackers want to take control of the technology and use it for military purpose.");
            Console.WriteLine("While the Allied Forces want to store the technology as if it never happened.");
            Console.WriteLine("Currently the coutries are debating at the UN before military action...");
            Console.Clear();
            Console.WriteLine("USA: THIS IS RIDICULOUS! If we militarized this technology one attack could wipe a whole country off the map!!!");
            Console.ReadLine();
            Console.WriteLine("Switzerland: Yes it could, but who said it would be used for military action on our own planet.");
            Console.ReadLine();
            Console.WriteLine("Russia: Switzerland is right! We have come in contact with alien technology, if aliens come and attack us what is our defense?");
            Console.WriteLine("We need this technology for our planets protection!");
            Console.ReadLine();
            Console.WriteLine("Canada: Well, we can still use it when we need it if it's in storage."); 
            Console.WriteLine("There is no need to militarize it.");
            Console.ReadLine();
            Console.WriteLine("Japan: Yeah, and when we need it we will have no clue how to use it.");
            Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Ok " + country + " it's your time to shine! Please choose a response that you think would suit your country best.");
            Console.WriteLine("A) Canada is right why should we fully militarize it? I don't think we shouldn't store it but research it.");
            Console.WriteLine("B) Why should we store it!? This is a massive power that was made by something other than humans and we need to defend ourselves from who made this.");
            Console.WriteLine("C) Both sides have valid points but I still feel like both of these options aren't the best we need to think of a more reasonable option.");
            Console.WriteLine("Choose A, B or C");
            Begin = false;
            
            //Sorting how well connected you are with your allies and how big of a target with enemies
            do
            {
                answer = Console.ReadLine();
                if (answer == "A")
                {
                    target = 0.33;
                    loanrate = 0.10;
                    Begin = true;
                }
                else if (answer == "B")
                {
                    loanrate = 0.35;
                    target = 0.25;
                    Begin = true;
                }
                else if (answer == "C")
                {
                    loanrate = 0.20;
                    target = 0.45;
                    Begin = true;
                }
                else
                    Console.WriteLine("I'm sorry I didn't understand that.");
            } while (Begin == false);
            
            answer = "";
            //Starting the game
            Console.Clear();
            Console.WriteLine("Ok, it time to go to war! You can enter a tutorial by typing 'Tutorial'.");
            answer = Console.ReadLine();
            if (answer == "Tutorial")
            {
                Console.WriteLine("There are several stages...");
                Console.WriteLine("Stage 1: Recruitment");
                Console.WriteLine("In this stage your receive a certain ammount of soldiers (recruitment rate)");
                Console.WriteLine();
                Console.ReadLine();
                Console.WriteLine("Stage 2: Receive income");
                Console.WriteLine("Each country gets a certain ammount of money per turn. Use this money for upgrades.");
                Console.WriteLine();
                Console.ReadLine();
                Console.WriteLine("Stage 3: Action!");
                Console.WriteLine("In this stage you can send troops to countries to fight or upgrade your stats or keep your troops on your land for defense.");
                Console.WriteLine();
                Console.ReadLine();
                Console.WriteLine("If a country reaches 0 soldiers or 0 HP or reaches the max ammount of enemy soldiers in their country then they are out of the game.");
                Console.ReadLine();
            }
            //Practice
            Enemy = "CPU1";
            Console.Clear();
            Console.WriteLine("Lets do a practice 1v1 round.");
            int moneyRate = (money / 3);
            do
            {
                win = false;
                //Stage 1
                Console.Clear();
                soldiers = (soldiers + soldierRate);
                Console.WriteLine("You have gained  " + soldierRate + "  soldiers");
                Console.ReadLine();

                //Stage 2
                Console.WriteLine("You have earned $" + moneyRate + ".");
                Console.ReadLine();

                //Stage 3
                Console.Clear();
                answer = ""; 
                Console.WriteLine("Please select a menu...");
                Console.WriteLine("Attack");
                Console.WriteLine("Defend");
                Console.WriteLine("Upgrade");
                answer = Console.ReadLine();
                
                //Attack
                if (answer == "Attack") 
                {
                    answer = "";
                    Console.WriteLine("Who would you like to attack?");
                    Console.WriteLine(Enemy);
                    answer = Console.ReadLine();
                    if (answer == Enemy)
                    {
                        answer = "";
                        Console.WriteLine("How many soldiers would you like to send?");
                        Console.WriteLine("You have  " + soldiers + "  soldiers");
                       int sendSoldiers = int.Parse(Console.ReadLine());
                       soldiers = (soldiers - sendSoldiers); 
                       Random actNPC = new Random();
                       int NPCAction = actNPC.Next(1,3);
                       if (NPCAction == 1)
                       {
                           int sendSoldiersNPC = actNPC.Next(1000, 5000);
                           int soldiersNPC = (5000 - sendSoldiersNPC);
                        HP = HP - (strNPC * sendSoldiersNPC) - ((def * soldiers)/2);
                        HPNPC = HPNPC - (sendSoldiers * str) - ((soldiersNPC * defNPC)/2);
                        Console.WriteLine(country + "  has" + HP +"  HP.");
                        Console.WriteLine(Enemy + "  has" + HPNPC + "  HP.");
                        Console.ReadLine();
                       }
                       if (NPCAction == 2)
                       {
                           int sendSoldiersNPC = actNPC.Next(1000, 5000);
                           HPNPC = HPNPC - (sendSoldiers * str) - (sendSoldiersNPC * def);
                           Console.WriteLine(country + "  has" + HP + "  HP.");
                           Console.WriteLine(Enemy + "  has" + HPNPC + "  HP.");
                           Console.ReadLine();
                       }
                    }
                }
                
                //Defend
                else if (answer == "Defend")
                {
                    answer = "";
                    Console.WriteLine("Who would you like to defend?");
                    Console.WriteLine(country);
                    answer = Console.ReadLine();
                    if (answer == country)
                    {
                        answer = "";
                        Console.WriteLine("How many soldiers would you like to send?");
                        Console.WriteLine("You have  " + soldiers + "  soldiers");
                        int sendSoldiers = int.Parse(Console.ReadLine());
                        soldiers = (soldiers - sendSoldiers);
                        int curDef = (sendSoldiers * def);
                        Random actNPC = new Random();
                        int sendSoldiersNPC = actNPC.Next(700, 5000);
                        HP = HP - (strNPC * sendSoldiersNPC) - (sendSoldiers * def);
                        Console.WriteLine("You have  " + HP + "  HP.");
                    }
                }
                
                //Upgrade
                else if (answer == "Upgrade")
                {
                    answer = "";
                    Console.WriteLine("What would you like to upgrade?");
                    Console.WriteLine("You have $" + money);
                    Console.WriteLine();
                    Console.WriteLine("A) Upgrade soldier rate (600000)");
                    Console.WriteLine("B) Upgrade money rate (700000)");
                    Console.WriteLine("C) Upgrade soldier strength (1000000)");
                    Console.WriteLine("D) Upgrade soldier defense (1000000)");
                    Console.WriteLine("To buy an upgrade, type the corresponding letter before the upgrade");
                    answer = Console.ReadLine();
                    if (answer == "A")
                    {
                        if (money < 600000)
                        {
                            Console.WriteLine("Sorry you do not have enough money...");
                        }
                        else if (money >= 600000)
                        {
                            soldierRate = soldierRate + 200;
                            Console.WriteLine("You have upgraded your soldier rate.");
                            Console.WriteLine("You know spawn" + soldierRate + "  per turn.");
                            Console.ReadLine();
                        }
                    }
                    else if (answer == "B")
                    {

                    }

                }
                else
                {
                    answer = "";
                    Console.WriteLine("Sorry, I didn't understand that.");
                }

            if (HPNPC <= 0)
            win = true;
            else if (HP <= 0)
            {
                Console.Clear();
                Console.WriteLine(country + "  has been defeated... Press any key to end the game.");
                Console.ReadLine();
                Environment.Exit(0);
            }
            } while (win == false);
            Console.WriteLine("You win!");
            Console.ReadLine();
            Console.WriteLine("That was just a small bit of the game...");
        }
    }
}


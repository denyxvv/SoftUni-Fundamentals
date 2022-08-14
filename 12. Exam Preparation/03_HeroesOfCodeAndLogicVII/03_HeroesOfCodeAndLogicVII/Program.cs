using System;
using System.Collections.Generic;
using System.Linq;

namespace _03_HeroesOfCodeAndLogicVII
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Hero> heroes = new List<Hero>();
            int n = int.Parse(Console.ReadLine());
            for(int i=1; i<=n;i++)
            {
                string[] segments = Console.ReadLine().Split();
                Hero hero = new Hero(segments[0], int.Parse(segments[1]), int.Parse(segments[2]));
                heroes.Add(hero);
            }
            string commands;
            while((commands = Console.ReadLine())!="End")
            {
                string[] segments = commands.Split(" - ");
                string action = segments[0];
                string heroName = segments[1];
                switch (action)
                {
                    case "CastSpell":
                        int mpNeeded = int.Parse(segments[2]);
                        string spellName = segments[3];
                        foreach(Hero x in heroes)
                        {
                            if(x.HeroName==heroName)
                            {
                                if(x.Mp>=mpNeeded)
                                {
                                    x.Mp -= mpNeeded;
                                    Console.WriteLine($"{x.HeroName} has successfully cast {spellName} and now has {x.Mp} MP!");
                                }
                                else
                                {
                                    Console.WriteLine($"{x.HeroName} does not have enough MP to cast {spellName}!");
                                }
                            }
                        }
                        break;
                    case "TakeDamage":
                        int damage = int.Parse(segments[2]);
                        string attacker = segments[3];
                        foreach (Hero x in heroes)
                        {
                            if (heroName == x.HeroName)
                            {
                                x.Hp -= damage;
                                if (x.Hp > 0)
                                {
                                    Console.WriteLine($"{x.HeroName} was hit for {damage} HP by {attacker} and now has {x.Hp} HP left!");
                                }
                                else
                                {
                                    Console.WriteLine($"{x.HeroName} has been killed by {attacker}!");
                                }
                            }
                        }
                        break;
                    case "Recharge":
                        int amountMp = int.Parse(segments[2]);
                        foreach(Hero x in heroes)
                        {
                            if(x.HeroName == heroName)
                            {
                                int oldMp = x.Mp;
                                x.Mp += amountMp;
                                if(x.Mp>200)
                                {
                                    amountMp = 200 - oldMp;
                                    x.Mp = 200;
                                }
                                Console.WriteLine($"{x.HeroName} recharged for {amountMp} MP!");
                            }
                        }
                        break;
                    case "Heal":
                        int amountHp = int.Parse(segments[2]);
                        foreach(Hero x in heroes)
                        {
                            if(x.HeroName == heroName)
                            {
                                int oldHp = x.Hp;
                                x.Hp += amountHp;
                                if(x.Hp>100)
                                {
                                    amountHp = 100 - oldHp;
                                    x.Hp = 100;
                                }
                                Console.WriteLine($"{x.HeroName} healed for {amountHp} HP!");
                            }    
                        }
                        break;
                }
            }
            foreach(Hero x in heroes)
            {
                if(x.Hp>0)
                {
                    Console.WriteLine(x.ToString());
                }
                
            }
        }
    }
    class Hero
    {
        public string HeroName { get; set; }
        public int Hp { get; set; }
        public int Mp { get; set; }
        public Hero(string heroName, int hp, int mp)
        {
            this.HeroName = heroName;
            this.Hp = hp;
            this.Mp = mp;
        }
        public override string ToString()
        {
            return $"{this.HeroName}\n HP: {this.Hp}\n MP: {this.Mp}";
        }
    }
}


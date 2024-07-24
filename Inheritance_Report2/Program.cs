using System.Data;
using System.Net.Security;
using System.Runtime.InteropServices;
using static Inheritance_Report2.Program;

namespace Inheritance_Report2
{
    
    public class Program
    {
        public enum Job { Adventurer, Fighter, Mage, Rogue }

        public class ChangedJob
        {
            public Job jobName;
            public int level;
            public int status;           
            

            public void Retitle()//전직 스위치문
            {
                switch (jobName)
                {
                    case Job.Adventurer:
                        Console.WriteLine($"{Job.Adventurer}로 전직했습니다.");
                        break;
                    case Job.Fighter:
                        Console.WriteLine($"{Job.Fighter}로 전직했습니다");
                        break;
                    case Job.Mage:
                        Console.WriteLine($"{Job.Mage}로 전직했습니다");
                        break;
                    case Job.Rogue:
                        Console.WriteLine($"{Job.Rogue}로 전직했습니다");
                        break;
                }
            }

            public virtual void UpgradeStatus()
            {                
                Console.WriteLine($"전직 특전으로 {status}가 상승했습니다.");
            }

            public virtual void ResetLevel()
            {                
                Console.WriteLine($"전직으로 {level}이 초기화 되었습니다");
            }


        }

        public class Adventurer : ChangedJob

        {

            public Adventurer()
            {
                int level = 1;
                int status = 5;
                Console.WriteLine($"레벨이 {level}, 스탯이 {status} 인 모험자로 시작합니다.");
            }

           
        }




        public class Fighter : ChangedJob
        {
            public Fighter()
            {
                jobName = Job.Fighter;
                level = 20;
                status = 20;                
                Console.WriteLine($"{Job.Adventurer}에서 {Job.Fighter} 전직!");
            }
            public override void UpgradeStatus()
            {
                status += 30;
                Console.WriteLine($"전직 특전으로 {status}가 상승했습니다.");
            }
            public override void ResetLevel()
            {
                level = 1;
                Console.WriteLine($"전직으로 {level}이 초기화 되었습니다");
            }

        }

        public class Mage : ChangedJob
        {
            public Mage()
            {
                jobName= Job.Mage;
                level = 20;
                status = 20;
                Console.WriteLine($"{Job.Adventurer}에서 {Job.Mage} 전직!");
            }
            public override void UpgradeStatus()
            {
                status += 10;
                Console.WriteLine($"전직 특전으로 {status}가 상승했습니다.");
            }
            public override void ResetLevel()
            {
                level = 1;
                Console.WriteLine($"전직으로 {level}이 초기화 되었습니다");
            }

        }

        public class Rogue : ChangedJob
        {
            public Rogue()
            {
                jobName = Job.Rogue;
                level = 20;
                status = 20;
                Console.WriteLine($"{Job.Adventurer}에서 {Job.Rogue} 전직!");
            }
            public override void UpgradeStatus()
            {
                status += 50;
                Console.WriteLine($"전직 특전으로 {status}가 상승했습니다.");
            }
            public override void ResetLevel()
            {
                level = 1;
                Console.WriteLine($"전직으로 {level}이 초기화 되었습니다");
            }
        }



        static void Main(string[] args)
        {
            Adventurer adventurer = new Adventurer();
            adventurer.Retitle();
            Console.WriteLine();

            Fighter fighter = new Fighter();
            fighter.Retitle();
            fighter.UpgradeStatus();
            fighter.ResetLevel();
            Console.WriteLine();

            Mage mage = new Mage();
            mage.Retitle();
            mage.UpgradeStatus();
            mage.ResetLevel();
            Console.WriteLine();

            Rogue rogue = new Rogue();
            rogue.Retitle();
            rogue.UpgradeStatus();
            rogue.ResetLevel();
            Console.WriteLine();


        }

    }
}

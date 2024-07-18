using System;

namespace Day_textRPG
{
    internal class Program
    {
        enum Scene { Seclect, Confirm, Town, Forest, Swarmp }
        enum Job { Warrior, Mage, Rogue }
        enum Monster { Slime }
        enum Inventory { Herb, Globe, Ball, Icecream }

        struct GameData
        {
            public bool running;//게임이 돌아가고 있으면 true값 반환, 종료되면 false값 반환
            public Scene scene;
            public Job job;
            public Monster monster;
            public string name;
            public int maxHP;
            public int currentHP;
            public int maxMP;
            public int currrentMP;
            public int Str;
            public int Dex;
            public int Intelligence;
            public int Def;
            public int Level;
            public int Exp;
            public int Gold;
            public Item[] inventory;
        }

        struct Item
        {
            public Inventory inventory;
            public string itemName;
            public int itemPrice;
        }

        static GameData data;//플레이어
        static GameData data2;//몬스터
        static Item data3;//아이템

        static int GetInt()
        {
            int input;
            bool success = int.TryParse(Console.ReadLine(), out input);
            while (true)
            {
                if (success)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("번호만 입력해주십시오.");
                }

            }
            return input;
        }

        static void PlayerStrAction()
        {
            if (data.Str > 14)
            {
                for (int i = 0; data2.currentHP > 0; i++)
                {
                    Console.WriteLine("당신은 슬라임을 공격합니다.");
                    Wait(1);
                    Console.WriteLine($"{data.Str} 만큼의 데미지를 주었습니다.");
                    Wait(1);
                    data2.currentHP = data2.currentHP - data.Str;
                    Console.WriteLine($"슬라임의 체력이 {data2.currentHP}가 됐습니다.");
                    Console.WriteLine();
                    if (data2.currentHP > 0)
                    {
                        PlayerStrAction();
                        Console.WriteLine();
                    }
                }
            }
        }

        static void PlayerDamagedAction()
        {
            Console.WriteLine("당신의 일격은 슬라임에게 통하지 않았습니다.");
            Wait(1);
            Console.WriteLine("슬라임의 반격!");
            Wait(1);
            Console.WriteLine("30의 데미지를 받았습니다.");
            data.currentHP = data.currentHP - data2.Str;
            Wait(1);
        }

        static void PlayerMagicAction()
        {
            if (data.Intelligence > 14)
            {
                for (int i = 0; data2.currentHP > 0; i++)
                {
                    Console.WriteLine("당신은 슬라임을 공격합니다.");
                    Wait(1);
                    Console.WriteLine($"{data.Intelligence} 만큼의 데미지를 주었습니다.");
                    Wait(1);
                    data2.currentHP = data2.currentHP - data.Intelligence;
                    Console.WriteLine($"슬라임의 체력이 {data2.currentHP}가 됐습니다.");
                    Console.WriteLine();
                    Wait(1);
                    if (data2.currentHP > 0)
                    {
                        PlayerMagicAction();
                        Console.WriteLine();
                    }
                }
            }
        }

        static void PlayerDexAction()
        {
            if (data.Dex > 14)
            {
                for (int i = 0; data2.currentHP > 0; i++)
                {
                    Console.WriteLine("당신은 슬라임을 공격합니다.");
                    Wait(1);
                    Console.WriteLine($"{data.Dex + data.Str} 만큼의 데미지를 주었습니다.");
                    Wait(1);
                    data2.currentHP = data2.currentHP - data.Dex - data.Str;
                    Console.WriteLine($"슬라임의 체력이 {data2.currentHP}가 됐습니다.");
                    Console.WriteLine();
                    Wait(1);
                    if (data2.currentHP > 0)
                    {
                        PlayerStrAction();
                        Console.WriteLine();
                    }
                }
            }
        }

        static void Inv()
        {

        }
        static void SelectScene()
        {
            Console.WriteLine("이름을 입력하세요 : ");
            data.name = Console.ReadLine();
            if (data.name == "")
            {
                Console.WriteLine("잘못된 입력입니다.");
                return;
            }
            Console.WriteLine();
            Console.WriteLine("직업을 선택해주세요.");
            Console.WriteLine($"1. {Job.Warrior,-3} 2. {Job.Mage,-3} 3. {Job.Rogue,-3}");
            int input2;
            bool success = int.TryParse(Console.ReadLine(), out input2);
            while (true)
            {
                if (success == true)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("1,2,3 중에 하나만 입력해주세요");
                    return;
                }
            }

            switch (input2)
            {
                case 1:
                    Console.WriteLine("전사를 선택하셨습니다.");
                    data.job = Job.Warrior;
                    data.Level = 1;
                    data.maxHP = 50;
                    data.currentHP = 50;
                    data.maxMP = 50;
                    data.currrentMP = 50;
                    data.Str = 18;
                    data.Dex = 8;
                    data.Intelligence = 5;
                    data.Gold = 100;
                    data.inventory = new Item[4];
                    Item Herb = new Item();
                    Item Globe = new Item();
                    Item Ball = new Item();
                    Item Icecream = new Item();
                    data.inventory[0] = Herb;
                    data.inventory[1] = Globe;
                    data.inventory[2] = Ball;
                    data.inventory[3] = Icecream;
                    //Console.Write($"{data.inventory[0]}, {data.inventory[1]},{data.inventory[2]}, {data.inventory[3]}\n");
                    /*foreach (Item arr in data.inventory)
                    {
                        Console.Write($"{arr}");                        
                    }*/
                    Wait(1);
                    break;
                case 2:
                    Console.WriteLine("마법사를 선택하셨습니다.");
                    data.job = Job.Mage;
                    data.Level = 1;
                    data.maxHP = 50;
                    data.currentHP = 50;
                    data.maxMP = 200;
                    data.currrentMP = 200;
                    data.Str = 6;
                    data.Dex = 5;
                    data.Intelligence = 20;
                    data.Gold = 300;
                    Wait(1);
                    break;
                case 3:
                    Console.WriteLine("도적을 선택하셨습니다.");
                    data.job = Job.Rogue; ;
                    data.Level = 1;
                    data.maxHP = 50;
                    data.currentHP = 50;
                    data.maxMP = 100;
                    data.currrentMP = 100;
                    data.Str = 12;
                    data.Dex = 18;
                    data.Intelligence = 13;
                    data.Gold = 50;
                    Wait(1);
                    break;
            }

            data.scene = Scene.Confirm;
        }



        static void ConfirmScene()
        {
            Console.WriteLine("************************************************");
            Console.WriteLine($"이름 : {data.name}");
            Console.WriteLine($"직업 : {data.job}");
            Console.WriteLine($"레벨 : {data.Level}");
            Console.WriteLine($" HP : {data.maxHP}");
            Console.WriteLine($" MP : {data.maxMP}");
            Console.WriteLine($" 힘 : {data.Str}");
            Console.WriteLine($"민첩 : {data.Dex}");
            Console.WriteLine($"지능 : {data.Intelligence}");
            //Console.WriteLine($"인벤토리 : {data3.inventory[0]}, {data3.inventory[1]}");
            //Console.Write($"{data.inventory[0]}, {data.inventory[1]},{data.inventory[2]}, {data.inventory[3]}\n");
            /*
            foreach (Item arr in data.inventory)
            {
                Console.Write($"{arr}");
            }*/
            Console.WriteLine($"소지금 : {data.Gold}");
            Console.WriteLine("************************************************");
            Console.Write("플레이 하시겠습니까?(Y/N) : ");
            string input = Console.ReadLine();

            if (input == "y" || input == "Y")
            {
                Wait(1);
                Console.Clear();
                data.scene = Scene.Town;
            }
            else
            {
                Wait(1);
                Console.Clear();
                data.scene = Scene.Seclect;
            }


        }

        static void TownScene()
        {
            Console.Clear();
            PlayerProfile();
            Console.WriteLine("마을에 도착했습니다.");
            Wait(1);
            Console.WriteLine("어디로 가시겠습니까?");
            Console.WriteLine($"1. {Scene.Forest,-3} 2. {Scene.Swarmp,-3}");
            int Input = GetInt();

            switch (Input)
            {
                case 1:
                    Console.WriteLine("당신은 숲으로 갑니다.");
                    Wait(1);
                    data.scene = Scene.Forest;
                    break;

                case 2:
                    Console.WriteLine("당신은 늪지대로 갑니다.");
                    Wait(1);
                    data.scene = Scene.Swarmp;
                    break;
            }
        }

        static void ForestScene()
        {
            PlayerProfile();
            Console.WriteLine("당신은 숲으로 들어갑니다.");
            Wait(1);
            Console.WriteLine("음산하고 소름끼치는 바람이 붑니다.");
            Wait(1);
            Console.WriteLine("숲을 빠져나가기 위해 걸어가고 있는데");
            Wait(1);
            Console.WriteLine("당신은 몬스터 슬라임과 조우했습니다.");
            data2.monster = Monster.Slime;
            data2.Level = 1;
            data2.maxHP = 30;
            data2.currentHP = 30;
            data2.maxMP = 0;
            data2.currrentMP = 0;
            data2.Str = 30;
            data2.Dex = 3;
            data2.Intelligence = 1;
            data2.Gold = 100;

            Wait(1);
            Console.WriteLine("당신의 행동을 선택해주세요.");
            Console.WriteLine("1. 슬라임을 공격한다.(힘)");
            Console.WriteLine("2. 공격마법을 사용한다.(지능)");
            Console.WriteLine("3. 슬라임 모르게 다가가서 배후에서 찌른다.(민첩)");
            Console.WriteLine("선택 : ");

            switch (GetInt())
            {
                case 1:
                    if (data.Str > 14)
                    {
                        PlayerStrAction();
                        Wait(1);
                        if (data2.currentHP <= 0)
                        {
                            MonsterDead();
                            Console.WriteLine("100 골드를 얻어 소지금이 100 골드 증가했습니다.");
                            data.Gold -= 100;
                        }
                    }
                    else
                    {
                        PlayerDamagedAction();
                        Wait(1);
                        if (data.currentHP > 0)
                        {
                            Console.WriteLine("행동을 선택해주세요");
                            Wait(1);
                            Console.WriteLine("1. 슬라임을 공격한다.(힘)");
                            Console.WriteLine("2. 공격마법을 사용한다.(지능)");
                            Console.WriteLine();
                            Console.Write("선택 : ");
                            int.TryParse(Console.ReadLine(), out int input2);

                            if (input2 == 1)
                            {
                                PlayerDamagedAction();
                                Wait(1);
                                if (data.currentHP <= 0)
                                {
                                    PlayerDead();
                                    Wait(2);
                                    Console.WriteLine("마을로 돌아갑니다...");
                                    Wait(2);
                                    data.currentHP = data.maxHP;
                                    data.scene = Scene.Town;
                                }
                            }
                            else if (input2 == 2)
                            {
                                PlayerDamagedAction();
                                Wait(1);
                                if (data.currentHP <= 0)
                                {
                                    PlayerDead();
                                    data.currentHP = data.maxHP;
                                    Console.Clear();
                                    Wait(2);
                                    data.scene = Scene.Town;
                                }
                            }
                        }
                    }
                    /*for (int i = 0; data.currentHP > 0; i++)
                    {
                        Console.WriteLine("당신은 마법으로 슬라임을 공격합니다.");
                        Wait(1);
                        Console.WriteLine($"{data.Intelligence}만큼의 데미지로 공격합니다.");
                        Wait(1);
                        data2.currentHP = data2.currentHP - data.Intelligence;
                        Console.WriteLine($"{data.Intelligence} 만큼의 데미지를 주었습니다.");
                        data2.currentHP = data2.currentHP - data.Intelligence;
                        Console.WriteLine($"슬라임의 체력이 {data2.currentHP}가 됐습니다.");
                        Wait(1);
                        PlayerDead();
                        if (data2.currentHP <= 0)
                        {
                            MonsterDead();
                            break;
                        }
                    }*/

                    /*bool success = int.TryParse(Console.ReadLine(), out int input2);
                     * if (success == true)
                    {
                        Console.WriteLine("당신은 슬라임을 공격합니다.");
                        Wait(1);
                        Console.WriteLine($"{data.Str}만큼의 데미지로 공격합니다.");
                        Wait(1);
                        data2.currentHP = data2.currentHP - data.Str;
                        Console.WriteLine($"{data.Str} 만큼의 데미지를 주었습니다.");
                        data2.currentHP = data2.currentHP - data.Str;
                        Console.WriteLine($"슬라임의 체력이 {data2.currentHP}가 됐습니다.");
                    }*/
                    break;

                case 2:
                    if (data.Intelligence > 15)
                    {
                        PlayerMagicAction();

                        if (data2.currentHP > 0)
                        {
                            Console.WriteLine("행동을 선택해주세요");
                            Wait(1);
                            Console.WriteLine("1. 슬라임을 공격한다.(힘)");
                            Console.WriteLine("2. 공격마법을 사용한다.(지능)");
                            Console.WriteLine();
                            Console.Write("선택 : ");
                            int.TryParse(Console.ReadLine(), out int input2);
                            if (input2 == 1)
                            {
                                PlayerDamagedAction();
                                Wait(1);
                                if (data.currentHP <= 0)
                                {
                                    PlayerDead();
                                    Wait(3);
                                    Console.WriteLine("마을로 돌아갑니다....");
                                    data.currentHP = data.maxHP;
                                    data.scene = Scene.Town;
                                }
                            }
                            else if (input2 == 2)
                            {
                                PlayerMagicAction();
                                Wait(1);
                                if (data2.currentHP <= 0)
                                {
                                    Console.WriteLine("100 골드를 얻어 소지금이 100 골드 증가했습니다.");
                                    data.Gold += 100;
                                }
                            }

                        }
                    }
                    else
                    {
                        PlayerDamagedAction();

                        if (data.currentHP > 0)
                        {
                            Console.WriteLine("행동을 선택해주세요");
                            Wait(1);
                            Console.WriteLine("1. 슬라임을 공격한다.(힘)");
                            Console.WriteLine("2. 공격마법을 사용한다.(지능)");
                            Console.WriteLine();
                            Console.Write("선택 : ");
                            int.TryParse(Console.ReadLine(), out int input2);
                            Wait(1);

                            if (input2 == 1)
                            {
                                for (int i = 0; data.currentHP > 0; i++)
                                {
                                    PlayerDamagedAction();
                                    Wait(1);
                                }
                            }
                            else if (input2 == 2)
                            {
                                PlayerMagicAction();
                                Wait(1);
                            }
                        }
                    }

                    break;
                case 3:
                    if (data.Dex > 15)
                    {
                        Console.WriteLine("당신은 슬라임에게 소리없이 다가가 찔러 치명적인 일격을 주었습니다.");
                        Wait(1);

                        PlayerDexAction();
                        if (data2.currentHP <= 0)
                        {
                            MonsterDead();
                            Console.WriteLine("100 골드를 얻어 소지금이 100 골드 증가했습니다.");
                            data.Gold += 100;
                            Wait(1);
                        }
                        else if (data2.currentHP > 0)
                        {
                            Console.WriteLine("행동을 선택해주세요");
                            Wait(1);
                            Console.WriteLine("1. 슬라임을 공격한다.(힘)");
                            Console.WriteLine("2. 공격마법을 사용한다.(지능)");

                            Console.WriteLine();
                            Console.Write("선택 : ");
                            int.TryParse(Console.ReadLine(), out int input2);
                            Wait(1);

                            if (input2 == 1)
                            {
                                PlayerStrAction();
                                Wait(1);
                            }
                            else if (input2 == 2)
                            {
                                PlayerDamagedAction();
                                Wait(1);
                                if (data.currentHP > 0)
                                {
                                    Console.WriteLine("행동을 선택해주세요");
                                    Wait(1);
                                    Console.WriteLine("1. 슬라임을 공격한다.(힘)");
                                    Console.WriteLine("2. 공격마법을 사용한다.(지능)");

                                    Console.WriteLine();
                                    Console.Write("선택 : ");
                                    int.TryParse(Console.ReadLine(), out int input3);
                                    Wait(1);

                                    if (input3 == 1)
                                    {
                                        PlayerStrAction();
                                        Wait(1);
                                        if (data2.currentHP <= 0)
                                        {
                                            MonsterDead();
                                            Wait(1);
                                            Console.WriteLine("100 골드를 얻어 소지금이 100 골드 증가했습니다.");
                                            data.Gold += 100;
                                        }
                                    }
                                    else if (input3 == 2)
                                    {
                                        PlayerMagicAction();
                                        Wait(1);
                                        if (data2.currentHP <= 0)
                                        {
                                            MonsterDead();
                                            Wait(1);
                                            Console.WriteLine("100 골드를 얻어 소지금이 100 골드 증가했습니다.");
                                            data.Gold += 100;
                                        }

                                    }
                                }


                            }
                        }

                    }
                    else
                    {
                        PlayerDamagedAction();
                        Wait(1);
                        if (data.currentHP > 0)
                        {
                            Console.WriteLine("행동을 선택해주세요");
                            Wait(1);
                            Console.WriteLine("1. 슬라임을 공격한다.(힘)");
                            Console.WriteLine("2. 공격마법을 사용한다.(지능)");

                            Console.WriteLine();
                            Console.Write("선택 : ");
                            int.TryParse(Console.ReadLine(), out int input3);
                            Wait(1);

                            if (input3 == 1)
                            {
                                PlayerStrAction();
                                Wait(1);
                                if (data2.currentHP <= 0)
                                {
                                    MonsterDead();
                                    Wait(1);
                                    Console.WriteLine("100 골드를 얻어 소지금이 100 골드 증가했습니다.");
                                    data.Gold += 100;
                                    Wait(1);
                                }
                            }
                            else if (input3 == 2)
                            {
                                PlayerMagicAction();
                                Wait(1);
                                if (data2.currentHP <= 0)
                                {
                                    MonsterDead();
                                    Wait(1);
                                    Console.WriteLine("100 골드를 얻어 소지금이 100 골드 증가했습니다.");
                                    data.Gold += 100;
                                }

                            }
                        }

                    }
                    break;
            }
            Console.Clear();
            PlayerProfile();
            Console.WriteLine("다음 행동을 선택하십시오.");
            Console.WriteLine("1. 조금 더 탐색한다. 2. 마을로 돌아간다.");
            int.TryParse(Console.ReadLine(), out int input);
            Wait(1);
            if (input == 1)
            {
                Console.WriteLine("당신은 조금 더 탐색하기로 했습니다.");
                Wait(1);
                data.scene = Scene.Forest;
            }
            else
            {
                Console.WriteLine("당신은 마을로 돌아가기로 했습니다.");
                Wait(1);
                data.scene = Scene.Town;
            }
        }

        static void SwarmpScene()
        {
            Console.Clear();
            PlayerProfile();
            Console.WriteLine("당신은 늪지대로 왔습니다.");
            Wait(1);
            Console.WriteLine("당신의 행동을 선택해주세요.");
            Console.WriteLine($"1. {"늪지대 안으로 들어간다",-3} 2. {"마을로 돌아갑니다.",-3}");
            Wait(1);
            int.TryParse(Console.ReadLine(), out int input);

            switch (input)
            {
                case 1:
                    if (data.Intelligence > 18)
                    {
                        Console.WriteLine("당신은 늪지대 안에서 한 식물을 발견합니다.");
                        Wait(1);
                        Console.WriteLine("높은 지능 덕분에 그 식물의 가치를 알아보고 획득합니다.");
                        Wait(1);
                        Console.WriteLine("약초를 습득했습니다.");

                    }
                    else if (data.Intelligence < 18)
                    {
                        Console.WriteLine("늪으로 발을 들이미는 순간 늪이 당신을 옭아들려 합니다.");
                        Wait(1);
                        Console.WriteLine("20의 데미지를 받았습니다.");
                        data.currentHP -= 20;
                        PlayerDead();
                        Wait(1);
                        Console.WriteLine("당신은 늪지대 안에서 한 식물을 발견합니다.");
                        Wait(1);
                        Console.WriteLine("당신은 약초에 대한 지식이 없습니다.");
                        Wait(1);
                        Console.WriteLine("그냥 지나쳐 버렸습니다.");
                    }
                    Wait(1);
                    Console.WriteLine("늪지대에서 돌아와 마을로 돌아갑니다.");
                    break;

                case 2:
                    Console.WriteLine("당신은 늪지대가 위험함을 깨닫고 마을로 돌아갑니다.");
                    Wait(1);
                    break;
            }
            data.scene = Scene.Town;
        }

        static void PlayerDead()
        {
            if (data.currentHP <= 0)
            {
                Console.WriteLine($"당신의 HP는 {data.currentHP}가 됐습니다");
                Console.WriteLine("당신은 죽었습니다.");
                Console.WriteLine("************************************************");
                Console.WriteLine("**   ******       ******** **********   ********");
                Console.WriteLine("** ** ***** ************* * ********* *** ******");
                Console.WriteLine("** **** *** ************ *** ******** ***** ****");
                Console.WriteLine("** ********       ***** ***** ******* ****** ***");
                Console.WriteLine("** **** *** **********         ****** ***** ****");
                Console.WriteLine("** ** ***** ********* ********* ***** *** ******");
                Console.WriteLine("**   ******       ** *********** ****   ********");
                Console.WriteLine("************************************************");
                Wait(3);


            }
            else
            {
                Console.WriteLine($"당신의 현재 HP는 {data.currentHP} 남았습니다.");
            }
        }

        static void MonsterDead()
        {
            if (data2.currentHP <= 0)
            {
                Console.WriteLine($"슬라임의 HP가 {data2.currentHP}가 됐습니다");
                Wait(1);
                Console.WriteLine("슬라임이 죽었습니다.");
                Wait(1);
            }
            else
            {
                Console.WriteLine($"슬라임의 현재HP : {data2.currentHP}");
            }
        }
        static void PlayerProfile()
        {
            Console.WriteLine("************************************************");
            Console.WriteLine($"이름 : {data.name}");
            Console.WriteLine($"직업 : {data.job}");
            Console.WriteLine($"레벨 : {data.Level}");
            Console.WriteLine($" HP : {data.currentHP}");
            Console.WriteLine($" MP : {data.currrentMP}");
            Console.WriteLine($" 힘 : {data.Str}");
            Console.WriteLine($"민첩 : {data.Dex}");
            Console.WriteLine($"지능 : {data.Intelligence}");
            //Console.Write($"{data.inventory[0]}, {data.inventory[1]},{data.inventory[2]}, {data.inventory[3]}");
            Console.WriteLine($"소지금 : {data.Gold}");
            Console.WriteLine("************************************************");
            Console.WriteLine();
        }

        static void Wait(float seconds)
        {
            Thread.Sleep((int)seconds * 1000);
        }
        static void Main(string[] args)
        {
            Start();

            while (data.running)
            {
                Run();
            }
            End();
        }

        static void Run()
        {
            Console.Clear();

            switch (data.scene)
            {
                case Scene.Seclect:
                    SelectScene();
                    break;
                case Scene.Confirm:
                    ConfirmScene();
                    break;
                case Scene.Town:
                    TownScene();
                    break;
                case Scene.Forest:
                    ForestScene();
                    break;
                case Scene.Swarmp:
                    SwarmpScene();
                    break;
            }
        }

        static void Start()
        {
            data = new GameData();

            data.running = true;

            Console.Clear();
            Console.WriteLine("************************************************");
            Console.WriteLine("**     **      ** **** *     *    *    *      **");
            Console.WriteLine("**** **** ******** ** **** *** ** * ** * **** **");
            Console.WriteLine("**** **** *********  ***** *** ** * ** * **** **");
            Console.WriteLine("**** ****      ****  ***** ***    *    * *******");
            Console.WriteLine("**** **** ******** ** **** *** ** * ****      **");
            Console.WriteLine("**** **** ******* **** *** *** ** * **** ***  **");
            Console.WriteLine("**** ****      * ****** ** *** ** * ****      **");
            Console.WriteLine("************************************************");
        }

        static void End()
        {

            Console.Clear();

        }
    }
}



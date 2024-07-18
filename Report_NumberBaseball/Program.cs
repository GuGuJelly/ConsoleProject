using System.ComponentModel.Design;

namespace Report_NumberBaseball
{
    internal class Program
    {

        static void Main(string[] args)
        {
            int cNumber1 = 3;
            int cNumber2 = 4;
            int cNumber3 = 5;
            Console.WriteLine($"{cNumber1}{cNumber2}{cNumber3}");
            Console.WriteLine("컴퓨터는 3개의 숫자를 기억했답니다. 인간님 숫자를 입력해주세요 : ");

            for (int i = 1; i < 12; i++)
            {
                if(i == 11)
                {
                    Console.WriteLine("컴퓨터의 승리!");
                }
                Console.WriteLine($"{i}번째 이닝 시작!");
                Console.WriteLine("인간님 3개의 숫자를 입력 부탁드립니다 : ");
                int.TryParse(Console.ReadLine(), out int input1);
                int.TryParse(Console.ReadLine(), out int input2);
                int.TryParse(Console.ReadLine(), out int input3);
                Console.WriteLine($"{input1}{input2}{input3}");
                if (input1 == cNumber1 && input2 == cNumber2 && input3 == cNumber3)
                {
                    Console.WriteLine("3스트라이크!");
                    Console.WriteLine("축하드립니다. 게임에서 이겼습니다.");
                    break;
                }
                else
                {
                    if (input1 != cNumber1)
                    {
                        Console.Write("볼, ");
                    }
                    else if (input1 == cNumber1)
                    {
                        Console.Write("스트라이크, ");
                    }
                    if (input2 != cNumber2)
                    {
                        Console.Write("볼, ");
                    }
                    else if (input2 == cNumber2)
                    {
                        Console.Write("스트라이크, ");
                    }
                    if (input3 != cNumber3)
                    {
                        Console.Write("볼");
                    }
                    else if (input3 == cNumber3)
                    {
                        Console.Write("스트라이크");
                    }
                    Console.WriteLine();
                    if (input1 != cNumber1 && input2 != cNumber2 && input2 != cNumber3)
                    {
                        Console.WriteLine("아웃!");
                    }
                    

                }
            }
        }

    }
}


namespace Report_Structure
{
    internal class Program
    {
        enum Maker { Honda, Audi, BMW, Kia }//자동차 제조사
        enum ItemType { Armor, Weapon, Usable }
        struct XYCoord
        {
            public short x;
            public short y;
        }

        struct Weapon
        {
            public int Dmg;
            public float Critical;
            public string Name;
        }

        struct Car
        {
            public Maker makerCar;
            public float maxSpeed;//최고속도
            public int carNumber;//자동차넘버                                 
        }

        struct Item
        {
            public ItemType itemType;
            //enum ItemType { Armor, Weapon, Usable }// 잘못된 선언
            public string nameItem;//아이템 이름
            public int priceItem;//아이템 가격            
        }
        static void Main(string[] args)
        {
            Weapon Sword = new Weapon() { Dmg = 45, Critical = 50, Name = "롱소드" };
            Weapon Katana = new Weapon() { Dmg = 50, Critical = 30, Name = "카타나" };
            Item[] items = new Item[3];
            items[0] = new Item() { nameItem = "포션", priceItem = 50, itemType = ItemType.Usable };
            items[1] = new Item() { nameItem="꽃게", priceItem = 100, itemType = ItemType.Weapon};
            items[2] = new Item() { nameItem = "악몽의 꽃 견갑", priceItem = 500,  itemType=ItemType.Armor };

            /*
            items[2].nameItem = "악몽의 꽃 견갑";
            items[2].priceItem = 500;
            items[2].Armor = ItemType.Armor;*/

            foreach (Item item in items)
            {
                Console.WriteLine($"{item.nameItem},{item.priceItem},{item.itemType}");
            }
        }
    }
}

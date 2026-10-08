using System.ComponentModel;
using System.ComponentModel.Design;

List<int> Vegosszeg = new List<int>() ;
int fut = 1;
int boxar = 15000;
int vegosszeg1 = 0;


while (fut !=4) 
{
    int osszertek = 0;
    Console.WriteLine("A Ló neve");
    string nev = Console.ReadLine();
    Console.WriteLine("Bérelt napok(db):");
    int napok = int.Parse(Console.ReadLine());

    Console.WriteLine("Kiemelt VIP box (true/fanse)");
    Boolean vip = Boolean.Parse(Console.ReadLine());
    int alapertek = napok * boxar;
    Console.WriteLine($"{alapertek}Ft a box alapértéke!");


    if (vip == true) ;
    {
        Console.WriteLine($"{alapertek-(alapertek/100)*15}Ft a box kedvezményesen!");
        int alape = alapertek - (alapertek / 100) * 15;
        vegosszeg1 = vegosszeg1 + alapertek - (alapertek / 100) * 15;
    }

    if (napok == 7) 
    {
        Console.WriteLine($"{alapertek - (alapertek / 100 * 15)}Ft a box kedvezményesen!");
        vegosszeg1 = vegosszeg1 + alapertek - (alapertek / 100) * 15;
    }

    else if (napok > 3) 
    {
        Console.WriteLine($"{alapertek - (alapertek / 100) * 5}Ft a box kedvezményesen!");
        vegosszeg1 = vegosszeg1 + alapertek - (alapertek / 100) * 5;
    }
    else{
        Console.WriteLine($"{alapertek}Ft a box ára!");
        vegosszeg1 = vegosszeg1 + alapertek;
    }
    
    fut = fut + 1;
}

////if vegosszeg < 200000{

//}
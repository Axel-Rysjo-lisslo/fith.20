fighter p1 = new fighter();
p1.name = "BEN";
p1.vapen = new wepons();
p1.vapen.name = "ugh";

fighter p2 = new fighter();
p2.name = "TOM";
p2.vapen = new wepons();
p2.vapen.name ="HOHOHO";


Random generator = new Random();


while (p1.hp > 0 && p2.hp >0 )
{
   Console.WriteLine("\n ---- ==== ny rönd === -----");
   Console.WriteLine($"{p1.name}:{p1.hp} || {p2.name}:{p2.hp}\n");


   p1.attack(p2);
   p2.attack(p1);

Console.WriteLine("tryck en knap!");
Console.ReadKey();


}





Console.ReadLine();

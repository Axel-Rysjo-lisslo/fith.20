fighter p1 = new fighter();
p1.name = "BEN";
p1.vapen = new wepons();
p1.vapen.name = "ugh";

fighter p2 = new fighter();
p2.name = "TOM";
p2.vapen = new wepons();
p2.vapen.name ="HOHOHO";










int damage = p1.vapen.attack();


p2.hp -= damage;


Console.WriteLine(p1.vapen.name);




Console.ReadLine();

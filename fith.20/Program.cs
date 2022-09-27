fighter p1 = new fighter();
fighter p2 = new fighter();
p1.vapen = new wepons();



int damage = p1.vapen.attack();


p2.hp -= damage;


Console.WriteLine(p1.vapen.name);




Console.ReadLine();

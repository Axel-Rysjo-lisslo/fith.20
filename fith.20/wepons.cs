using System;

public class wepons
{



 public string name;
private Random generator;

public wepons()
{

generator = new Random();

}

public int GetDamage()
{

return generator.Next(10,30);

}

} 




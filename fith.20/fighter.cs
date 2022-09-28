using System;


public class fighter
{

public string name;
public int hp = 100;

public wepons vapen;

public void attack(fighter mål)
{

int damage = vapen.GetDamage();
mål.hp -= damage;
mål.hp  = Math.Max(0, mål.hp);
Console.WriteLine($"{name} gör {damage} på {mål}");



}


}
using System;



public class wepons
{

public int max;
public int min;
 
 public string name;


private  Random generator = new Random(); 


public int attack()
{
return generator.Next(10,20);


} 



}

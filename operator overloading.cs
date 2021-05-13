using System;
class Candy {
    public Candy(string name, int weight, double price){
        Name = name;
        Weight = weight;
        Price = price;
        
    }
    public string Name{get;set;}
    public int Weight{get;set;}
    public double Price{get;set;}
    
    public static Candy operator +(Candy c, Candy d){
        string tempName=c.Name + " " + d.Name;
        int tempWeight=c.Weight+d.Weight;
        double tempPrice=c.Price+d.Price;
        return new Candy(tempName,tempWeight, tempPrice);
    }
    public static void Main(){
        Candy first = new Candy("kit", 12, 3.0);
        
        Candy second = new Candy("kat", 18, 5.0);
        
        Candy added = first + second;
        
        Console.WriteLine("{0} weight: {1} price: {2}", added.Name, added.Weight, added.Price);
    }
}

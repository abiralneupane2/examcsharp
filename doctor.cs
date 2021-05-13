using System;
class Doctor {
    public string Name{get;set;}
    public int Age{get;set;}
    protected double salary;
    virtual public double Salary{
        get{
            return salary;
        }
        set{
            if (value<12000)
                salary = 12000;
            else
                salary = value;
        }
    
    }
    public override string ToString(){
        return (GetType() + "  " + Name + " " + Age + " Salary: " + Salary);
    }
}
class Specialist:Doctor{
    public string Field{get;set;}
    public override double Salary{
        get{
            return 250000;
        }
    }
    public override string ToString(){
        return (GetType() + "  " + Name + " " + Age + " Field: " + Field + " Salary: " + Salary);
    }
}
class Medicine{
    public static void Main(){
        Doctor d = new Doctor();
        Specialist s = new Specialist();
        d.Name = "Aanchal";
        d.Age = 25;
        d.Salary = 11000;
        s.Name = "Ishwor";
        s.Age = 35;
        s.Field = "Orthopedic";
        Console.WriteLine(d.ToString());
        Console.WriteLine(s.ToString());
    }
}

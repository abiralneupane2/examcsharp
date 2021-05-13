using System;
class PhotoStudio{
    static void Main(){
        Photo photo = new Photo();
        MattedPhoto mattedPhoto = new MattedPhoto();
        FramedPhoto framedPhoto = new FramedPhoto();
        photo.Height=22.0;
        photo.Width=23.0;
        photo.Width = 8;
        photo.Height = 9;
        mattedPhoto.Width = 10;
        mattedPhoto.Height = 12;
        mattedPhoto.Color = "white";
        framedPhoto.Width = 8;
        framedPhoto.Height = 10;
        framedPhoto.Material = "silver";
        framedPhoto.Style = "modern";
        Console.WriteLine(photo.ToString());
        Console.WriteLine(mattedPhoto.ToString());
        Console.WriteLine(framedPhoto.ToString());
    }
}
class Photo{
    double height;
    public double Width{get;set;}
    private double price;
    protected double Price{
        get{
            return price;
        }
    }
    public double Height{
        get{
            return height;
        }
        set{
            height=value;
            setPrice();
        }
    }
    protected void setPrice(){
        if (height==8.0 && Width==10.0)
            price = 3.99;
        else if (height==10.0 && Width==12.0)
            price = 3.99;
        else
            price = 9.9;
    }
    
    public override string ToString(){
        return (GetType() + "  " + Width + " X " + height + " Price: " + price);
    }
}
class MattedPhoto : Photo{
    public string Color { get; set; }
    new public double Price{
        get{
            return base.Price + 10;
        }
    }
    public override string ToString()
    {
        return (GetType() + "   " + Color + " matting " +
          Width + " X " + Height + "   Price: " + Price);
    }
}
class FramedPhoto : Photo
{
    public string Material { get; set; }
    public string Style { get; set; }
    new public double Price{
        get{
            return base.Price + 25;
        }
    }
    public override string ToString()
    {
        return (GetType() + "    " + Style + ", " + Material + " frame " +
           Width + " X " + Height + "   Price: " + Price);
    }
}

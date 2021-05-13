using System;
class ProductOrder{
    static void Main(){
        Order order = new Order();
        ShippedOrder shippdeOrder = new ShippedOrder();
        order.OrderNumber=1;
        order.CustomerName="Name";
        order.QuantityOrdered=5;
        shippdeOrder.OrderNumber=2;
        shippdeOrder.CustomerName="Another name";
        shippdeOrder.QuantityOrdered=3;
        shippdeOrder.Date="15/02/2021";
        Console.WriteLine(order.ToString());
        Console.WriteLine(shippdeOrder.ToString());
    }
}
class Order{
    public int OrderNumber{get;set;}
    public string CustomerName{get;set;}
    int quantityOrdered;
    protected double totalPrice;
    public int QuantityOrdered{
        get{
            return quantityOrdered;
        }
        set{
            quantityOrdered=value;
            totalPrice = QuantityOrdered*19.5;
        }
    }
    public double TotalPrice{
        get{
            return totalPrice;
        }
    }
    public override string ToString(){
        return (GetType() + "  " + OrderNumber + " :" + CustomerName + " Quantity ordered: " + QuantityOrdered + " Total price: " + TotalPrice);
    }
}

class ShippedOrder:Order{
    string date;
    public string Date{
        get{
            return date;
        }
        set{
            date = value;
            base.totalPrice+=4;
        }
    }
    
    public override string ToString(){
        return (GetType() + "  " + OrderNumber + " :" + CustomerName + " Quantity ordered: " + QuantityOrdered + " Total price: " + TotalPrice + " Shipping date: " + Date);
    }
}

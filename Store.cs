using System;

//mcs -out:lights.exe lights.cs
//mono lights.exe

public class Card{


        private string name{get;set;}
        private double lastMonth{get;set;}
        private double discount{get;set;}
        private double thisMonth{get;set;}

        public Card(){
          
        }
        public Card(string name,double lastMonth){
            
            this.name=name;
            this.lastMonth= lastMonth;
            this.discount=0;
            thisMonth=0;
            
            
        }
         public void CalculateDiscount(){
          
        }
        public void makePurchase(double price){
          double discountPrice = discount*price/100;
          double newPrice= price-discountPrice;
          Console.WriteLine($"Price: {price}\n");
          Console.WriteLine($"Discount rate: {this.discount}%\n");
          Console.WriteLine($"Discount amount: {discountPrice}\n");
          Console.WriteLine($"New price: {newPrice}\n");

        }
       
public class BronzeCard:Card{

        public BronzeCard(string name,double lastMonth){
            
            this.name=name;
            this.lastMonth= lastMonth;
            this.discount=0;
            thisMonth=0;
            Console.WriteLine("Bronze card made!");
            
            
            
        }
        public new void CalculateDiscount(){
            if(lastMonth>=100 && lastMonth<=300){
                this.discount=1;
            }
            else if(lastMonth>300){
                this.discount=2.5;
            }
            else{
                this.discount=0;
            }
        }
}
public class SilverCard:Card{

        public SilverCard(string name,double lastMonth){
            
            this.name=name;
            this.lastMonth= lastMonth;
            this.discount=2;
            thisMonth=0;
            
            
            
        }
        public new void  CalculateDiscount(){
            if(lastMonth>300){
                this.discount=3.5;
            }
            else{
                this.discount=2;
            }
        }
}
public class GoldCard:Card{

        public GoldCard(string name,double lastMonth){
            
            this.name=name;
            this.lastMonth= lastMonth;
            this.discount=2;
            thisMonth=0;
            
            
            
        }
        public  new void  CalculateDiscount(){
            double curr=this.lastMonth/100;
            curr= Math.Floor(curr);
            curr=curr>10?10:curr;
            this.discount=curr;

            
        }
}
       
class Store {
 
    
  static void Main() {
    
    
    Console.WriteLine("Hello user, please enter your name:\n");
    string name = Console.ReadLine();
    Console.WriteLine($"Hello {name}, what card do you have?:\n1. Bronze\n2. Silver\n3. gold");
    int idCard=Convert.ToInt32(Console.ReadLine());
    double lastMonth;
    Console.WriteLine($"Hello {name}, how much did you spend last month?");
    lastMonth=Convert.ToDouble(Console.ReadLine());

    double price;
    switch (idCard)
    {
        case 1:
        BronzeCard karticaB=new BronzeCard(name,lastMonth);
        
    Console.WriteLine($"Okey {name}, we made you a card\nI hear you want to make a purchuse, how much is your total?");
    price=Convert.ToDouble(Console.ReadLine());
    karticaB.CalculateDiscount();
    karticaB.makePurchase(price);

        break;
        case 2:
        SilverCard karticaS= new SilverCard(name,lastMonth);
        
    Console.WriteLine($"Okey {name}, we made you a card\nI hear you want to make a purchuse, how much is your total?");
    price=Convert.ToDouble(Console.ReadLine());
    karticaS.CalculateDiscount();
    karticaS.makePurchase(price);
         break;
        case 3:
        GoldCard karticaG = new GoldCard(name,lastMonth);
      
    Console.WriteLine($"Okey {name}, we made you a card\nI hear you want to make a purchuse, how much is your total?");
    price=Convert.ToDouble(Console.ReadLine());
    karticaG.CalculateDiscount();
    karticaG.makePurchase(price);
         break;
        default:
        
        break;
    }
    


  }
}
}


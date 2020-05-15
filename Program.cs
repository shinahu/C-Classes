using System;

namespace Task_1._5_Class
{
class Program
    {
       
        static void Main(string[] args)
        {
            // Instantiate a new cookie 
            var yellow = new Color(5,6,7,"Yellow");
            var brown = new Color(10,20,32,"Brown");
            
            var cookie2 = new Cookie (10, "star",brown);
            var cookie3 = new Cookie (20, "heart",yellow);
            var cookie4 = new Cookie (5, "triangle",brown);
            var cookie5 = new Cookie (11, "circle",yellow);

             System.Console.WriteLine();
             System.Console.WriteLine("The cookie weight is " + cookie2.weight + " grams and shaped like a " + cookie2.shape + " with color " + cookie2.cl.name);
             System.Console.WriteLine("The cookie weight is " + cookie3.weight + " grams and shaped like a " + cookie3.shape + " with colors " + cookie3.cl.name);
             System.Console.WriteLine("The cookie weight is " + cookie4.weight + " grams and shaped like a " + cookie4.shape + " with colors " + cookie4.cl.name);
             System.Console.WriteLine("The cookie weight is " + cookie5.weight + " grams and shaped like a " + cookie5.shape + " with colors " + cookie5.cl.name);
        }
    }

// second class 
public class Color {
  
  public int blue = 0;
   public int green = 0;
   public int red = 0;

   public string name = "";

   public Color (int b, int g, int r, string n){

       this.blue = b;
       this.green = g;
       this.red = r;
       this.name = n;
   }
   }


public class Cookie 
{ 
    // Attributes
     public int weight;
     public string  shape;
     public Color cl;
     

     
// constructors 
 public Cookie(int w, string s)
 
 { 
     this.weight = 0;
     this.shape = "";
     
     

  }
  public Cookie(int w, string s, Color n)
  {

  this.weight = w;
  this.shape = s;
  this.cl = n;
  
    
  }

  
    
  
  
}
}
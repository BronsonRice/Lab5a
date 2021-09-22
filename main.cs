using System;

class Program {
  public static void Main (string[] args) {
    
    // declaring variables
    double total = 0;
    int i = 1;
    
      
    
    
     for(i=1;i<=7;i++){
    // These statements will go in a loop //
     
    Console.WriteLine("Enter the distance covered by car#" +i);
    double distance = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine ("Enter time taken by car#" + i);
    double time = Convert.ToDouble(Console.ReadLine());
    double speed = distance/time;
    Console.WriteLine("The speed of this car is " + speed + " miles per hour " );
    total = total + speed;
    
    }

    double average = total/7;
    Console.WriteLine("The average speed of the cars is " + average);
    

    

    

    


  }
}


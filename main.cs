using System;

class Program {
  public static void Main (string[] args) {

    double bills = 300;

    if(bills == 0.01){
      Console.WriteLine("No Person is found in PHP " + bills);
    }
    else if(bills == 0.05){
      Console.WriteLine("No Person is found in PHP" +  bills);
    }
    else if(bills == 0.25){
      Console.WriteLine("No Person is found in PHP " + bills);
    }
    else if(bills == 1){
      Console.WriteLine("Jose Rizal is found in PHP " + bills);
    }
    else if(bills == 5){
      Console.WriteLine("Emilio Aguinaldo is found in PHP " + bills);;
    }
    else if(bills == 10){
      Console.WriteLine("Andres Bonifacio and Apolinario Mabini is found in PHP " + bills);
    }
    else if(bills == 20){
      Console.WriteLine("Manuel Quezon is found in PHP " + bills);
    }
    else if(bills == 50){
      Console.WriteLine("Sergio Osmena is found in PHP " + bills);
    }
    else if(bills == 100){
      Console.WriteLine("Manuel Roxas is found in PHP " + bills);
    }
    else if(bills == 200){
      Console.WriteLine("Diosdado Macapagal is found in PHP " + bills);
    }
    else if(bills == 500){
      Console.WriteLine("Benigno Aquino Sr. and Corazon Aquino is found in PHP " + bills);
    }
    else if(bills == 1000){
      Console.WriteLine("Jose Abad Santos, Josefa Escoda, and Vicente Lim is found in PHP " + bills);
    }
    else{
      Console.WriteLine("Invalid Denomination: " + bills);
    }
  }
}
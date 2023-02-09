using System;

class Program {
  public static void Main (string[] args) {
  //Escreva um algoritimo para ler ema temperatura em graus Fahrenhelt, calcula e escrever o valor correspondente em graus Celsius (baseado na formula abaixo):
    
  String ent;
  Double Fah,Cel;
    
     Console.WriteLine ("Escreva a temperatura em Fahrenhehelt");
     ent = Console.ReadLine();
    Fah = Double.Parse(ent);
     Cel = 5.0/9.0*(Fah-32.0);
     Console.WriteLine ("Celsius"+ Cel);
    
  }
}
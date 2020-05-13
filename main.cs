/*
Antone Cabral
5/12/2020

Assignment Week 10.1

Filename: Assignment_10_Cabral.cs

Purpose:
String parse items in a list splitting the name of the item and it's price into seperate arrays.
*/

using System;

class MainClass {
  public static void Main (string[] args) {
    
    string[] items = { "Widget 15.50", "Thingy 50.99", "Ratchet25.00", "Clanger115.49", "Fracker75.25" };

    string[] item_names = new string[items.Length];
    double[] item_prices = new double[items.Length];

    //Call parseList method and pass in items, names, and prices arrays
    parseList(items, item_names, item_prices);

    //Print names and prices arrays
    for (int i = 0; i < items.Length; ++i) {
      Console.WriteLine("{0} ${1:0.00}", item_names[i], item_prices[i]);
    }

    Console.WriteLine("Press any key to continue");
    Console.ReadKey();

  }

  //parseList - Method to utilize substring on items to split the names and prices to individual arrays.
  public static void parseList (string[] items, string[] item_names, double[] item_prices) {
    for (int i = 0; i < items.Length; ++i) {
      item_names[i] = items[i].Substring(0,7); //gets chars from first to 7 positions 
      item_prices[i] = Double.Parse(items[i].Substring(7)); //gets chars from position 7 to end of string
    }


  }



}
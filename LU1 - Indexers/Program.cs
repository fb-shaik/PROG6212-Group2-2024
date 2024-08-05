using System;
using System.ComponentModel.DataAnnotations;

public class Example
{
    // This is the array operator: []
    //Indexer: Allows objects to be indexed in a similar way as arrays
    //This means you can access elements within an object using the [] symbol
    //Indexers are defined using the 'this' keyword & can also have single/many parameters
    //Parameters are seen as properties & instead of accessing single values it would allow you
    //to access multiple values via the index
    //Parameters & return types of the the indexer can be different
    //Mainly used due to encapsulation

    //Private array to hold the integer values
    private int[] numbers = new int[10];

    public int this[int index] 
    { 
        //get & set to access & retrieve the value at a specified index
        get {return numbers[index];}
        set {numbers[index] = value;}
    }

}

public class Program {

    public static void Main(string[] args) { 

        //create an instance of the Example class above
        Example example = new Example();

        //set the value at the index 0 of the numbers array to 5 using the indexer
        example[0] = 5;

        //Retrieve the value at index 0 of the numbers array using the indexer
        int value = example[0]; 

        //output message to verify the above
        Console.WriteLine(value);//expected value: 5

    
    
    }

}


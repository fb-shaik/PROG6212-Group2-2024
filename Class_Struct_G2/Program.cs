using System;

class Program {
    public static void Main(string[] args) 
    { 
        //using the class - Person
        //create 2 objects, initialize with name & age for object 1
            Person person1 = new Person("Joe",27); //created an instance with name Joe & 27
        
        //for object two: assign person1 reference to person2
        Person person2 = person1; //Person2 is seen as a reference copy

        //change the name for person2 (whats happens?)
        person2.Name ="Bob"; //this will also change person1.Name since both ref the same object

        //Display the details of person1 & person2
        person1.Display(); //Output: Name: Bob, Age:27
        person2.Display(); //Output: Name: Bob, Age:27

        //Using the struct
        //create 2 objects, initialize the first object (X & Y)
        Point point1 = new Point(10,20);

        //for object two: assign point1 reference to point2 (value copy)
        Point point2 = point1;

        //change X for point2 (whats happens?)
        point2.X = 30; //Change the X value of point2 only (point1 remains the same)

        //Display the details of point1 & point2
        point1.Display(); //Output: X:10, Y:20
        point2.Display(); //Output: X:30, Y:20






    }

}

//Class to represent a person with name & age; display method to show properties
public class Person 
{ 
    //properties to get/set the name & age
    public string Name { get; set; }
    public int Age { get; set; }

    //Constructor to initialize the name & age
    public Person (string name, int age) 
    { 
        Name = name;
        Age = age;
    }

    //Display method 
    public void Display() 
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}");
    }

}

//Struct to represent a point with X & Y co-ordinates
public struct Point 
{ 
    //Properties to get/set the X & Y co-ordinates
    public int X { get; set; }
    public int Y { get; set; }

    //Constructor to initialize the X & Y co-ordinates
    public Point(int x, int y) 
    { 
        X= x;
        Y= y;
    }

    //Method to display the co-ordinates
    public void Display() 
    {
        Console.WriteLine($"X: {X}, Y: {Y}");
    }

}
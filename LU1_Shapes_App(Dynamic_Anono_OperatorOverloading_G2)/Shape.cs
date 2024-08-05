using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LU1_Shapes_App_Dynamic_Anono_OperatorOverloading_G2_
{
    //Define an abstract base class: Shape
     public abstract class Shape
    {
        //property to hold name of the shape
        public string Name { get; set; }

        //abstract method to calculate the area of a shape
        public abstract double GetArea();

    }

    //Define a child class: Circle that inherits from Shape
    public class Circle : Shape
    {
        //property to hold the radius of the circle
        public double Radius { get; set; }

        //Constructor to initialize the radius & set the name to "Circle"
        public Circle(double radius)
        {
            Name = "Circle";
            Radius = radius;
        }
        //Override the GetArea method to calculate the area of the cicrle
        public override double GetArea()
        {
            return Math.PI * Radius * Radius;
        }

        //Operator Overloading for the + operator
        public static Circle operator +(Circle a, Circle b) 
        { 
            //calculate the new radius from the sum of the areas of the two circle objects
            return new Circle(Math.Sqrt((a.GetArea() + b.GetArea()) / Math.PI));    
            
        }

    }
    
    //Define a second class: Rectangle inherits from Shape
    //have properties that holds width & height
    //Constructor to initialize the width & height, set Name to "Rectangle"
    //Override the GetArea() to calculate the area of a rectangle
    //Overload the + operator: add the areas of 2 rectangle objects for a new instance of Rect. Class

}

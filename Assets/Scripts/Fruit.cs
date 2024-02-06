/*****************************************************************************
// File Name : Comments.cs
// Author : Jack Parrott
// Creation Date : 1/25/24
//
// Brief Description : Fruit class that contains info (name, weght and color)
                        of the fruit
*****************************************************************************/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruit //start and update dont work without mono behiaviour 
{
    public string name;
    public string color;
    public float weight;
    /// <summary>
    /// Constructor for fruit class that takes 3 paramaters
    /// </summary>
    /// <param name="name">Name of fruit</param>
    /// <param name="c">Fruit Color</param>
    /// <param name="w">Fruit Weight</param>
    public Fruit(string name, string c, float w) //function with peramaters
    {
        this.name = name;
        color = c;
        weight = w;
    }

    public Fruit() //makes default paramerts for when none are inputed
    {
        name = "Banana";
        color = "blue";
        weight = 3.7f;
    }

    public Fruit(string name)
    {
        this.name = name;
        color = "red";
        weight = 1.0f;
    }

    public Fruit(float weight)
    {
        name = "watermelon";
        color = "white";
        this.weight = weight;
    }


    ~Fruit() //Destructors use ~
    {
        //write to a file
        name = "";
        weight = 0f;
        color = "clear";
    }
}

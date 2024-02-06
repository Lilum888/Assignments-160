/*****************************************************************************
// File Name : Comments.cs
// Author : Jack Parrott
// Creation Date : 1/25/24
//
// Brief Description : Gathers info for the fruit class in a list and prints 
                        it
*****************************************************************************/

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitManager : MonoBehaviour
{

    public List<Fruit> fruitSalad; //declare list of fruit
    /// <summary>
    /// Start is called before the first frame update
    /// </summary>
    void Start()
    {
        fruitSalad = new List<Fruit>(); //defining the list of fruits

        Fruit apple = new Fruit("apple", "Green", 1.2f); //Input a new fruit with the constructer 
        fruitSalad.Add(apple); //adds apple to fruit salad

        CreateFruitSalad();
        DisplayFruitSalad();
    }

    private void DisplayFruitSalad()
    {
        for (int i = 0; i < fruitSalad.Count; i++) //prints the whole list
        {
            print(fruitSalad[i].color+" "+ fruitSalad[i].name + " Weighs" + fruitSalad[i].weight);
        }
    }

    private void CreateFruitSalad()
    {
        fruitSalad.Add(new Fruit()); //using no parameters

        fruitSalad.Add(new Fruit("Strawberry")); // using one parameter

        fruitSalad.Add(new Fruit(7.8f));
    }

    /// <summary>
    /// Update is called once per frame
    /// </summary>
    void Update()
    {
        
    }
}

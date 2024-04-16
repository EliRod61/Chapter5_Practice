
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Character
{
    public string name;
    public int exp = 0;
    //Constructor
    public Character()
    {
        name = "Not assigned";
    }
    //2nd Constructor
    public Character(string name)
    {
        this.name = name;
    }
    
}

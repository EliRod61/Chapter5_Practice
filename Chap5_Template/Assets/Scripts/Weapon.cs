
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public struct Weapon
{
    public string name;
    public int damage;

    //Constructor
    public Weapon(string name, int damage)
    {
        this.name = name;
        this.damage = damage;
    }
    //Method
    public void PrintWeaponStats()
    {
        Debug.LogFormat("Weapon: {0} - {1} DMG", this.name, this.damage);
    }
}

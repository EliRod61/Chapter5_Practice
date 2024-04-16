
using OpenCover.Framework.Model;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
public class LearningCurve : MonoBehaviour
{
    public int CurrentAge = 30;
    public int addedAge = 1;
    // Start is called before the first frame update
    void Start()
    {
        //var hero = new Character();
        Character hero = new Character();
        hero.PrintStatsInfo();
 
        Character villain = hero;
        villain.name = "Sir Kane the Bold";
        villain.PrintStatsInfo();

        Character heroine = new Character("Agatha");
        heroine.PrintStatsInfo();

        /*
         * Classes are reference types so they cannot be copied when assigned to new variables. 
         * Any change to one reference trickles through all other variables holding the same reference.
         * Both hero and villain will have the name: Sir Kane the Bold.
         */

        Weapon huntingBow = new Weapon("Hunting Bow", 105);
        huntingBow.PrintWeaponStats();

        Weapon warBow = huntingBow;
        warBow.name = "War Bow";
        warBow.damage = 155;
        warBow.PrintWeaponStats();

        /*
         * Structs are easily copied and modified as their separate objects.
         * Unlike classes, which retain references to an original object.
         * warBow will print a different sentence with different values compared to huntingBow
         */

        ComputeAge();
    }
    /// <summary>
    /// We add up 2 numbers and print them to the console.
    /// </summary>
    void ComputeAge()
    {
        Debug.Log(CurrentAge + addedAge);
        /*
        * This is where I would put the rest of my code...
        * IF I HAD SOME!
        */
    }
    // Update is called once per frame
    void Update()
    {

    }
}


using OpenCover.Framework.Model;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
public class LearningCurve : MonoBehaviour
{
    public int CurrentAge = 30;
    public int addedAge = 1;
    public Transform CamTransform;
    public GameObject DirectionLight;
    public Transform LightTransform;
    // Start is called before the first frame update
    void Start()
    {
        //var hero = new Character();
        Character hero = new Character();
        hero.PrintStatsInfo();
        //hero.Reset();

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

        Paladin knight = new Paladin("Sir Arthur", huntingBow);
        knight.PrintStatsInfo();

        CamTransform = this.GetComponent<Transform>();
        Debug.Log(CamTransform.localPosition);

        //DirectionLight = GameObject.Find("Directional Light");
        LightTransform = DirectionLight.GetComponent<Transform>();
        Debug.Log(LightTransform.localPosition);

        //ComputeAge();
    }
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


using System.Collections;
using System.Collections.Generic;
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

        Character heroine = new Character("Agatha");
        heroine.PrintStatsInfo();

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

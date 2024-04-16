
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
        Character hero = new Character();
        //var hero = new Character();
        Debug.LogFormat("Hero: {0} - {1} EXP", hero.name, hero.exp);
        //Debug.Log(CurrentAge+ 1);
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
        //This class is fun
    }
}

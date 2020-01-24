using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningCurve : MonoBehaviour
{
    private Transform camTransform;

    // Start is called before the first frame update
    void Start()
    {
        camTransform = this.GetComponent<Transform>();
        Debug.Log(camTransform.localPosition);

        //Character hero = new Character();
        //Character hero2 = hero;
        //hero2.name = "Joey2";
        //hero.PrintStatsInfor();
        //hero2.PrintStatsInfor();

        //Character heroine = new Character("Destiny");
        //heroine.PrintStatsInfor();

        //Weapon huntingBow = new Weapon("Hunting Bow", 105);
        //Weapon warBow = huntingBow;

        //Paladin knight = new Paladin("Sir Arthur", huntingBow);
        //knight.PrintStatsInfor();
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}

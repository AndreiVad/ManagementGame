using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointSystem : MonoBehaviour {


    public static int wood = 100;
    public static int iron = 100;
    public static int stone = 100;
    public static int soil = 100;
    public static int wool;
    public static int gold;


    public static int wood1 = 250;
    public static int iron1 = 250;
    public static int stone1 = 250;
    public static int soil1 = 250;
    public static int wool1;
    public static int gold1;


    public float time = 1;




    // Use this for initialization
    void Start () {


        

    }

    // Update is called once per frame
    void Update () {

        time -= Time.deltaTime;

        if (time <= 0)
        {

            wood++;
            iron++;
            stone++;
            soil++;



            wood1++;
            iron1++;
            stone1++;
            soil1++;


            time = 1;
        }

    }
}

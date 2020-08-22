using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIBuildStrategy : MonoBehaviour
{

    public static int strategy = 1;

    static float time = 0;


    // Start is called before the first frame update
    void Start()
    {

        if (time <= 0)
        {


            float x = Random.value;

            if (x <= 0.3)
            {

                strategy = 1;


            }
            else if (x > 0.3 && x <= 0.6)
            {
                strategy = 2;
            }

            else if (x > 0.6)
            {
                strategy = 3;
            }
            Debug.Log(strategy);
            Debug.Log("the strategy was");

        }
    }

    // Update is called once per frame
    void Update()
    {

        time = time - Time.deltaTime;


    }
}

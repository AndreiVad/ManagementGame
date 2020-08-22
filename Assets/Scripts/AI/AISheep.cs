using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AISheep : MonoBehaviour
{
    // Start is called before the first frame update
    public FarmAppear script;

    public static int meeh = 0;


    public float time = 2;

    int wool = 0;



    // Start is called before the first frame update
    void Start()
    {
        transform.GetChild(1).gameObject.SetActive(false);

        script = GetComponent<FarmAppear>();

    }

    // Update is called once per frame
    void Update()
    {
        

        time -= Time.deltaTime;

        if (AIBuildStrategy.strategy == 1)
        {
            if (!transform.GetChild(1).gameObject.activeInHierarchy)
            {

                if (AIWorkings.marketStolen == true || PointSystem.wood1 > 160 || PointSystem.stone1 > 160 || PointSystem.iron1 > 160 || PointSystem.soil1 > 160)
                {

                    if (PointSystem.wood1 > 50 && PointSystem.stone1 > 50 && PointSystem.soil1 > 50 && PointSystem.iron1 > 50)
                    {
                        PointSystem.wood1 = PointSystem.wood1 - 50;
                        PointSystem.stone1 = PointSystem.stone1 - 50;
                        PointSystem.soil1 = PointSystem.soil1 - 50;
                        PointSystem.iron1 = PointSystem.iron1 - 50;
                        transform.GetChild(1).gameObject.SetActive(true);
                        script.enabled = false;

                    }
                }
            }


        }


        if (AIBuildStrategy.strategy == 2)
        {

            if (!transform.GetChild(1).gameObject.activeInHierarchy)
            {

                if (PointSystem.wood1 > 50 && PointSystem.stone1 > 50 && PointSystem.soil1 > 50 && PointSystem.iron1 > 50)
                {
                    PointSystem.wood1 = PointSystem.wood1 - 50;
                    PointSystem.stone1 = PointSystem.stone1 - 50;
                    PointSystem.soil1 = PointSystem.soil1 - 50;
                    PointSystem.iron1 = PointSystem.iron1 - 50;
                    transform.GetChild(1).gameObject.SetActive(true);
                    script.enabled = false;
                    meeh = 1;
                }
            }

        }


        if (AIBuildStrategy.strategy == 3)
        {

            if (!transform.GetChild(1).gameObject.activeInHierarchy)
            {

                if (PointSystem.wood1 > 50 && PointSystem.stone1 > 50 && PointSystem.soil1 > 50 && PointSystem.iron1 > 50)
                {
                    PointSystem.wood1 = PointSystem.wood1 - 50;
                    PointSystem.stone1 = PointSystem.stone1 - 50;
                    PointSystem.soil1 = PointSystem.soil1 - 50;
                    PointSystem.iron1 = PointSystem.iron1 - 50;
                    transform.GetChild(1).gameObject.SetActive(true);
                    script.enabled = false;

                }
            }

        }

        if (transform.GetChild(1).gameObject.activeInHierarchy && time <= 0)
        {

            wool++;
            time = 2;
        }


        if ((AIWorkings.marketStolen == true || AIWorkings.marketTaken == true) && transform.GetChild(1).gameObject.activeInHierarchy && time <=0)
        {

            PointSystem.wood1 = PointSystem.wood1 + wool;
            PointSystem.stone1 = PointSystem.stone1 + wool;
            PointSystem.soil1 = PointSystem.soil1 + wool;
            PointSystem.iron1 = PointSystem.iron1 + wool;
            wool = 0;

        }



    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIWood : MonoBehaviour
{

    public SawMillAppear script;

    public float time = 2;


    // Start is called before the first frame update
    void Start()
    {
        transform.GetChild(1).gameObject.SetActive(false);

        script = GetComponent<SawMillAppear>();

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

                    if (PointSystem.wood1 > 10 && PointSystem.stone1 > 20 && PointSystem.soil1 > 20 && PointSystem.iron1 > 40)
                    {
                        PointSystem.wood1 = PointSystem.wood1 - 10;
                        PointSystem.stone1 = PointSystem.stone1 - 20;
                        PointSystem.soil1 = PointSystem.soil1 - 20;
                        PointSystem.iron1 = PointSystem.iron1 - 40;
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

                if (AIWorkings.marketSheep == true || PointSystem.wood1 > 160 || PointSystem.stone1 > 160 || PointSystem.iron1 > 160 || PointSystem.soil1 > 160)
                {

                    if (PointSystem.wood1 > 10 && PointSystem.stone1 > 20 && PointSystem.soil1 > 20 && PointSystem.iron1 > 40)
                    {
                        PointSystem.wood1 = PointSystem.wood1 - 10;
                        PointSystem.stone1 = PointSystem.stone1 - 20;
                        PointSystem.soil1 = PointSystem.soil1 - 20;
                        PointSystem.iron1 = PointSystem.iron1 - 40;
                        transform.GetChild(1).gameObject.SetActive(true);
                        script.enabled = false;

                    }
                }
            }
        }





        if (AIBuildStrategy.strategy == 3)
        {
            if (!transform.GetChild(1).gameObject.activeInHierarchy)
            {
                if (PointSystem.wood1 > 10 && PointSystem.stone1 > 20 && PointSystem.soil1 > 20 && PointSystem.iron1 > 40)
                {
                    PointSystem.wood1 = PointSystem.wood1 - 10;
                    PointSystem.stone1 = PointSystem.stone1 - 20;
                    PointSystem.soil1 = PointSystem.soil1 - 20;
                    PointSystem.iron1 = PointSystem.iron1 - 40;
                    transform.GetChild(1).gameObject.SetActive(true);
                    script.enabled = false;

                }
            }

        }

        if (transform.GetChild(1).gameObject.activeInHierarchy && time <= 0)
        {

            PointSystem.wood1++;
            time = 2;
        }

    }
}

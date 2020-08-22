using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIStone : MonoBehaviour
{
    // Start is called before the first frame update
    public QuarryAppear script;

    public float time = 2;


    // Start is called before the first frame update
    void Start()
    {
        transform.GetChild(1).gameObject.SetActive(false);

        script = GetComponent<QuarryAppear>();

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

                    if (PointSystem.wood1 > 20 && PointSystem.stone1 > 10 && PointSystem.soil1 > 40 && PointSystem.iron1 > 20)
                    {
                        PointSystem.wood1 = PointSystem.wood1 - 20;
                        PointSystem.stone1 = PointSystem.stone1 - 10;
                        PointSystem.soil1 = PointSystem.soil1 - 40;
                        PointSystem.iron1 = PointSystem.iron1 - 20;
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

                    if (PointSystem.wood1 > 20 && PointSystem.stone1 > 10 && PointSystem.soil1 > 40 && PointSystem.iron1 > 20)
                    {
                        PointSystem.wood1 = PointSystem.wood1 - 20;
                        PointSystem.stone1 = PointSystem.stone1 - 10;
                        PointSystem.soil1 = PointSystem.soil1 - 40;
                        PointSystem.iron1 = PointSystem.iron1 - 20;
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

                if (PointSystem.wood1 > 20 && PointSystem.stone1 > 10 && PointSystem.soil1 > 40 && PointSystem.iron1 > 20)
                {
                    PointSystem.wood1 = PointSystem.wood1 - 20;
                    PointSystem.stone1 = PointSystem.stone1 - 10;
                    PointSystem.soil1 = PointSystem.soil1 - 40;
                    PointSystem.iron1 = PointSystem.iron1 - 20;
                    transform.GetChild(1).gameObject.SetActive(true);
                    script.enabled = false;

                }
            }
        }






        if (transform.GetChild(1).gameObject.activeInHierarchy && time <= 0)
        {

            PointSystem.stone1++;
            time = 2;
        }
    }
}

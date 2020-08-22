using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIWorkings : MonoBehaviour
{
    public float time = 2;

    public static bool marketStolen = false;
    public static bool marketTaken = false;
    public static bool marketSheep = false;


    public MarketAppear script;

    // Start is called before the first frame update
    void Start()
    {
        transform.GetChild(1).gameObject.SetActive(false);

        script = GetComponent<MarketAppear>();
     
    }

    // Update is called once per frame
    void Update()
    {

        if (AIBuildStrategy.strategy == 1) {

            if (!transform.GetChild(1).gameObject.activeInHierarchy)
            {

                if (PointSystem.wood1 > 150 && PointSystem.stone1 > 150 && PointSystem.soil1 > 150 && PointSystem.iron1 > 150)
                {
                    PointSystem.wood1 = PointSystem.wood1 - 150;
                    PointSystem.stone1 = PointSystem.stone1 - 150;
                    PointSystem.soil1 = PointSystem.soil1 - 150;
                    PointSystem.iron1 = PointSystem.iron1 - 150;
                    transform.GetChild(1).gameObject.SetActive(true);
                    script.enabled = false;

                    marketStolen = true;

                }
            }
           

        }


        if (AIBuildStrategy.strategy == 2)
        {
            if (!transform.GetChild(1).gameObject.activeInHierarchy)
            {
                if (PointSystem.wood1 > 150 && PointSystem.stone1 > 150 && PointSystem.soil1 > 150 && PointSystem.iron1 > 150 && AISheep.meeh == 1)
                {
                    PointSystem.wood1 = PointSystem.wood1 - 150;
                    PointSystem.stone1 = PointSystem.stone1 - 150;
                    PointSystem.soil1 = PointSystem.soil1 - 150;
                    PointSystem.iron1 = PointSystem.iron1 - 150;
                    transform.GetChild(1).gameObject.SetActive(true);
                    script.enabled = false;

                    marketTaken = true;

                    marketSheep = true;



                    
                }

            }

        }

        if (AIBuildStrategy.strategy == 3)
        {
            if (!transform.GetChild(1).gameObject.activeInHierarchy)
            {
                if (PointSystem.wood1 > 150 && PointSystem.stone1 > 150 && PointSystem.soil1 > 150 && PointSystem.iron1 > 150)
                {
                    PointSystem.wood1 = PointSystem.wood1 - 150;
                    PointSystem.stone1 = PointSystem.stone1 - 150;
                    PointSystem.soil1 = PointSystem.soil1 - 150;
                    PointSystem.iron1 = PointSystem.iron1 - 150;
                    transform.GetChild(1).gameObject.SetActive(true);
                    script.enabled = false;

                    marketTaken = true;

                }

            }

        }



    }
}
    

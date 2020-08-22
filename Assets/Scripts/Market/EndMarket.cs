using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndMarket : MonoBehaviour
{

    public static int hasScore = 0;
    int finished = 0;

    public static float time = 500;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        time -= Time.deltaTime;

        if (time <= 0)
        {

            Time.timeScale = 0;
            finished = 1;

        }

        if (MarketAppear.marketTaken || FarMarketAppear.marketTaken)
        {
            hasScore = 1;
        }

        if (finished == 1 && hasScore ==1)
        {
            PointSystem.gold = PointSystem.gold + PointSystem.wood / 7;
            PointSystem.gold = PointSystem.gold + PointSystem.iron / 7;
            PointSystem.gold = PointSystem.gold + PointSystem.soil / 7;
            PointSystem.gold = PointSystem.gold + PointSystem.stone / 7;
            PointSystem.gold = PointSystem.gold + PointSystem.wool;
            PointSystem.wood = 0;
            PointSystem.iron = 0;
            PointSystem.soil = 0;
            PointSystem.stone = 0;
            PointSystem.wool = 0;
            Debug.Log("gold " + PointSystem.gold);
            Debug.Log("soil" + PointSystem.soil);

        }


    }


}

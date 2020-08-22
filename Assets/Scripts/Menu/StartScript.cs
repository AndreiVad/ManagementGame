using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartScript : MonoBehaviour
{
    public static int GameStarted = 0;  
    public Button button;
    GameObject go = null;

    // Start is called before the first frame update
    void Start()
    {
        if (GameObject.FindWithTag("MainCanvas") != null)
        {
            go = GameObject.FindWithTag("MainCanvas");
        }
        if (go != null) {
            go.SetActive(false);
        }
        Time.timeScale = 0;
        Button btn = button.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void TaskOnClick()
    {
        EndMarket.hasScore = 0;

        PointSystem.wood = 100;
        PointSystem.wood1 = 150;

        PointSystem.wool = 0;
        PointSystem.wool1 = 0;

        PointSystem.iron = 100;
        PointSystem.iron1 = 150;

        PointSystem.soil = 100;
        PointSystem.soil1 = 150;

        PointSystem.gold = 0;
        PointSystem.gold1 = 0;

        PointSystem.stone = 100;
        PointSystem.stone1 = 150;

        EndMarket.time = 500;
        EndMarket.hasScore = 0;


        FarMarketAppear.marketTaken = false;
        MarketAppear.marketTaken = false;


        go.SetActive(true);
        Time.timeScale = 2;
        GameStarted = 1;
        this.transform.parent.gameObject.SetActive(false);
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RestartScript : MonoBehaviour
{

    public Button button;

    // Start is called before the first frame update
    void Start()
    {
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

        SceneManager.LoadScene("SampleScene");
    }
}

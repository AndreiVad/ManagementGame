using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuyWood : MonoBehaviour
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
        if (PointSystem.gold > 10)
        {
            PointSystem.wood = PointSystem.wood + 10;
            PointSystem.gold = PointSystem.gold - 10;

        }
    }
}

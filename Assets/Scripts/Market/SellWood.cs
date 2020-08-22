using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class SellWood : MonoBehaviour
{
    // Start is called before the first frame update
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
        if (PointSystem.wood > 10)
        {
            PointSystem.wood = PointSystem.wood - 10;
            PointSystem.gold = PointSystem.gold + 1;

        }
    }

}

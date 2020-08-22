using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MarketButton : MonoBehaviour
{

    bool state;


    public Button button;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Button>().interactable = false;
        transform.GetChild(0).gameObject.SetActive(false);


        Button btn = button.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);

        

    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(FarMarketAppear.marketTaken);
        Debug.Log(MarketAppear.marketTaken);
        
        if (FarMarketAppear.marketTaken == true || MarketAppear.marketTaken == true ) {


            GetComponent<Button>().interactable = true;
           
            

        }
      


    }


    void TaskOnClick()
    {

        state = !state;        
        transform.GetChild(0).gameObject.SetActive(state);
         
         
    }

}





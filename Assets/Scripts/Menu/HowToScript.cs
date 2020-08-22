using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HowToScript : MonoBehaviour
{

    public Button button;
    GameObject go = null;
    // Start is called before the first frame update
    void Start()
    {

        transform.GetChild(1).gameObject.SetActive(false);
        Button btn = button.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);


    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void TaskOnClick()
    {

        transform.GetChild(1).gameObject.SetActive(true);
    }


}

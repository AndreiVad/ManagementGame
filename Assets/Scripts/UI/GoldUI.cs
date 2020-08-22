using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoldUI : MonoBehaviour
{

    public Text instruction;
    // Start is called before the first frame update
    void Start()
    {
        instruction = GetComponent<Text>();
    }




    // Update is called once per frame
    void Update()
    {
        instruction.text = "Gold:" + PointSystem.gold.ToString();

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WoodUI : MonoBehaviour
{

    public Text instruction;
    // Use this for initialization
    void Start()
    {
        instruction = GetComponent<Text>();
    }
  



    // Update is called once per frame
    void Update()
    {
        instruction.text = "Wood" + PointSystem.wood.ToString();

    }
}
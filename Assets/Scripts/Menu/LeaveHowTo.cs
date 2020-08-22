using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeaveHowTo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("escape"))
        {
 
            transform.gameObject.SetActive(false);
        }
    }
}

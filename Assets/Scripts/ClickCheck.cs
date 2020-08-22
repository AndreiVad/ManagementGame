using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickCheck : MonoBehaviour {

    public SawMillAppear sawmillscript;
    float InteractDistance = 30;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Input.GetMouseButtonDown(0)) {
            if (Physics.Raycast(ray, out hit, 100.0f))
            {
                Debug.DrawLine(Camera.main.transform.position, transform.position + transform.forward * InteractDistance, Color.green);
                if (hit.collider.tag == "sawmill")
                {
                    PrintName(hit.transform.gameObject);
                }
            }
        }
	}



    private void PrintName(GameObject go)
    {
        print(go.name);
    }

}

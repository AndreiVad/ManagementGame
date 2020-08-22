using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    

    private float speed = 5f;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        Vector3 pos = transform.position;


        if (Input.GetKey("w"))
        {
            pos.z += speed * Time.deltaTime;

        }

        if (Input.GetKey("s"))
        {
            pos.z -= speed * Time.deltaTime;

        }


        if (Input.GetKey("a"))
        {
            pos.x -= speed * Time.deltaTime;

        }


        if (Input.GetKey("d"))
        {
            pos.x += speed * Time.deltaTime;

        }

        pos.x = Mathf.Clamp(pos.x, -8f, 10f);
        pos.z = Mathf.Clamp(pos.z, -8f, 10f);




        transform.position = pos;



    }
}

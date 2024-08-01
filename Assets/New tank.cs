using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Newtank : MonoBehaviour
{
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey("w")){

                    transform.Translate(Vector3.forward * Time.deltaTime * 5);

        }
        if(Input.GetKeyDown("space")){

            rb.AddForce(transform.up * 20f,ForceMode.Impulse);
        }
        if(Input.GetKey("a")){

                    transform.Rotate(0f, -0.4f, 0f, Space.Self);

        }
        if(Input.GetKey("d")){

                    transform.Rotate(0f, 0.4f, 0f, Space.Self);

        }
        if(Input.GetKey("s")){

                    transform.Translate(Vector3.forward * Time.deltaTime * -5);

        }

        

    }

    
}

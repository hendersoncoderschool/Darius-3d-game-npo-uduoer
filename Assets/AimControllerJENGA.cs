using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AimControllerJENGA : MonoBehaviour
{
    private float vertical;
    private float horizontal;
    public float speed;
    public GameObject v;
    public float offset;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        vertical = Input.GetAxis("Mouse Y");
        transform.Rotate(Vector3.right, -vertical * speed * Time.deltaTime);
        horizontal = Input.GetAxis("Mouse X");
        transform.Rotate(Vector3.up, horizontal * speed * Time.deltaTime);


        if (Input.GetButtonDown("Fire1"))
        {
            GameObject projectile = (GameObject) Instantiate(v, transform.position + transform.forward * offset, Quaternion.identity);
            Rigidbody projectileRb = projectile.GetComponent<Rigidbody>();
            projectileRb.AddForce(20f * Vector3.forward, ForceMode.Impulse);
            
        }
    }
}

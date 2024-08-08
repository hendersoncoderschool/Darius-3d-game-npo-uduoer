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
    public float verticalRotationLimit = 50f;


    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Mouse X");
        transform.Rotate(Vector3.up, horizontalInput * speed * Time.deltaTime);

        float verticalInput = Input.GetAxis("Mouse Y");
        vertical -= verticalInput * speed * Time.deltaTime;
        vertical = Mathf.Clamp(vertical, -verticalRotationLimit, verticalRotationLimit);

        transform.localRotation = Quaternion.Euler(vertical, transform.localEulerAngles.y, 0f);

        if (Input.GetButtonDown("Fire1"))
        {
            GameObject projectile = (GameObject) Instantiate(v, transform.position + transform.forward * offset, Quaternion.identity);
            Rigidbody projectileRb = projectile.GetComponent<Rigidbody>();
            projectileRb.AddForce(20f * transform.forward, ForceMode.Impulse);
            
        }
    }
}
//vertical = Input.GetAxis("Mouse Y");
        //transform.Rotate(Vector3.right, -vertical * speed * Time.deltaTime);
        //horizontal = Input.GetAxis("Mouse X");
        //transform.Rotate(Vector3.up, horizontal * speed * Time.deltaTime);

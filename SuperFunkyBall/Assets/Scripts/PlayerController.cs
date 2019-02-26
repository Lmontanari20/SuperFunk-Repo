using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rb;
    public float speed;
    public float rotateSpeed;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();    
    }

    private void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        float h = Input.GetAxis("Horizontal") * rotateSpeed * Time.deltaTime;
        bool jump = Input.GetButtonDown("Fire1");
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rb.AddForce(movement * speed);
        rb.AddTorque(transform.right * h);

        if(jump)
        {
            Vector3 jumpForce = new Vector3(0.0f, 200.0f, 0.0f);
            rb.AddForce(jumpForce);
            Debug.Log("I should jump");
        }
    }


}

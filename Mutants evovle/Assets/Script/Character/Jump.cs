using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    // Jump
    public Rigidbody rb;
    public bool canJump = true;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //Jump
        if (Input.GetButtonDown("Jump") && canJump)
        {
            rb.velocity = new Vector3(0, 5, 0);
            canJump = false;
        }
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("floor"))
        {
            canJump = true;
        }
    }
}

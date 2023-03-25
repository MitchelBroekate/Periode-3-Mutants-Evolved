using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float hor;
    public float ver;
    public float moveSpeed;
    public Vector3 moveDirection;
    public float jumpSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        hor = Input.GetAxis("Horizontal");
        ver = Input.GetAxis("Vertical");

        moveDirection.x = hor;
        moveDirection.z = ver;

        transform.Translate(moveDirection * moveSpeed * Time.deltaTime);
    }
}

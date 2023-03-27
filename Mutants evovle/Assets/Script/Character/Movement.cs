using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    // Movement
    public float hor;
    public float ver;
    public float moveSpeed;
    public Vector3 moveDirection;
    public Conversationmanager conman;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // movement
        hor = Input.GetAxis("Horizontal");
        ver = Input.GetAxis("Vertical");

        moveDirection.x = hor;
        moveDirection.z = ver;

        if (conman.conbool == false)
        {
            transform.Translate(moveDirection * moveSpeed * Time.deltaTime);
        }
        
    }
}

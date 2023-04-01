using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycast : MonoBehaviour
{
    public RaycastHit hit;
    public Conversationmanager conman;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Physics.Raycast(transform.position, transform.forward, out hit, 10))
        {
            if (conman.conend == false)
            {
                if (hit.transform.tag == "Conversation")
                {
                    if (Input.GetKeyDown(KeyCode.E))
                    {
                        conman.constart = true;
                        conman.conbool = true;
                        
                        conman.confirst = true;

                    }
                }
            }
            
        }    

        
    }
}

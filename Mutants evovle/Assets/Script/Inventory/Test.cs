using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    public RaycastHit hit;
    public GameObject inventory;
    public bool ininv = false;
    public GameObject keycard;
    public bool pKeycard = false;
    public bool paper1 = false;
    public bool paper2 = false;
    public bool paper3 = false;
    public bool paper4 = false;

    void Update()
    {
        
        Physics.Raycast(transform.position, transform.forward, out hit, 1000);
        if (Input.GetKeyDown(KeyCode.Tab))
        { 
            if(ininv == true)
            {
                inventory.SetActive(false);
                ininv = false;
            }
            else
            {
                inventory.SetActive(true);
                ininv = true;
            }
        }
 
        


        if(hit.transform.tag == "Keycard")
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                pKeycard = true;

                if (pKeycard == true)
                {
                    keycard.SetActive(true);
                }
                else
                {
                    keycard.SetActive(false);
                    
                }
            }
        }


    }
}

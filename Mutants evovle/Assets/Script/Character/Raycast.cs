using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycast : MonoBehaviour
{
    public RaycastHit hit;
    public Conversationmanager conman;
    public GameObject keyCard;
    public bool isKeyInInv;
    public Animator animator;
    public Collider door;
    
    // Start is called before the first frame update
    void Start()
    {
        keyCard.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        //Ryan
        if (Physics.Raycast(transform.position, transform.forward, out hit, 10))
        {
            if (hit.transform.tag == "keycard")
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    keyCard.SetActive(false);
                    isKeyInInv = true;
                }
            }

            if (isKeyInInv == true)
            {
                if (hit.transform.tag == "keyslot")
                {
                    if (Input.GetKeyDown(KeyCode.E))
                    {
                        animator.SetBool("Dooropen", true);
                        //RO
                        door.enabled = false;
                    }
                }
            }

            //RO
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

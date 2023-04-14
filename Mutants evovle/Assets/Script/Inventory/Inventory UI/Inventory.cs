using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public RaycastHit hit;
    public GameObject inventory;
    public bool ininv = false;
    public GameObject keycard;
    public bool pKeycard = false;
    public bool paper1 = false;
    public GameObject code1;
    public bool paper2 = false;
    public GameObject code2;
    public bool paper3 = false;
    public GameObject code3;
    public bool paper4 = false;
    public GameObject code4;

    void Update()
    {
        Physics.Raycast(transform.position, transform.forward, out hit, 6);
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

        if (hit.transform.tag == "Code1")
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                paper1 = true;

                if (paper1 == true)
                {
                    code1.SetActive(true);
                }
                else
                {
                    code1.SetActive(false);

                }
            }
        }

        if (hit.transform.tag == "Code2")
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                paper2 = true;

                if (paper2 == true)
                {
                    code2.SetActive(true);
                }
                else
                {
                    code2.SetActive(false);

                }
            }
        }

        if (hit.transform.tag == "Code3")
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                paper3 = true;

                if (paper3 == true)
                {
                    code3.SetActive(true);
                }
                else
                {
                    code3.SetActive(false);

                }
            }
        }

        if (hit.transform.tag == "Code4")
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                paper4 = true;

                if (paper4 == true)
                {
                    code4.SetActive(true);
                }
                else
                {
                    code4.SetActive(false);

                }
            }
        }
    }
}

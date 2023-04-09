using UnityEngine;

public class Raycast : MonoBehaviour
{
    public RaycastHit hit;
    public Conversationmanager conman;

    public GameObject keyCard;
    public GameObject code1;
    public GameObject code2;
    public GameObject code3;
    public GameObject code4;

    public bool codeRed;
    public bool codeGreen;
    public bool codeYellow;
    public bool codeBlue;
    public bool isKeyInInv;
    public bool codeInInv;
    public KeyPad keyPad;

    public Animator animator;
    public Collider door;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Ryan
        if (Physics.Raycast(transform.position, transform.forward, out hit, 10))
        {
            //code
            if (hit.transform.tag == "Red1")
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    code1.SetActive(false);
                    print("red1");
                    codeRed = true;
                }
            }

            if (hit.transform.tag == "Green2")
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    code2.SetActive(false);
                    print("green2");
                    codeGreen = true;
                }
            }

            if (hit.transform.tag == "Yellow3")
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    code3.SetActive(false);
                    print("yellow3");
                    codeYellow = true;
                }
            }

            if (hit.transform.tag == "Blue4")
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    code4.SetActive(false);
                    print("blue4");
                    codeBlue = true;                  
                }
            }

            if (codeRed & codeGreen & codeYellow & codeBlue == true)
            {
                codeInInv = true;
            }

            if (codeInInv == true)
            {
                if (hit.transform.tag == ("keyslot"))
                {
                    if (Input.GetKeyDown(KeyCode.E))
                    {
                        keyPad.keypad = true;
                    }
                }
            }

            //keycard
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

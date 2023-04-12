using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeyPad : MonoBehaviour   
{
    public bool keypad;
    public bool correct;
    public Text ans;
    public Text exit;
    public string answer = "1234";
    public Animator animator;
    public Conversationmanager conman;

    // Start is called before the first frame update
    void Start()
    {
        keypad = false;
    }

    void Update()
    {
        if (correct == true)
        {
            exit.text = "Press Q";

            if (Input.GetKeyDown(KeyCode.Q))
            {
                keypad = false;
                animator.SetBool("Dooropen", true);
            }
        }
    }

    public void Number(int number)
    {
        ans.text += number.ToString();
    }

    public void Execute()
    {
        if (ans.text == answer)
        {
            ans.text = "ACCEPTED";            
            correct = true;
            conman.questint += 1;
        }
        else
        {
            ans.text = "Denied!";
        }
    }

    public void Clear()
    {
        if (ans.text != answer)
        {
            ans.text = "";
        }
    }
}

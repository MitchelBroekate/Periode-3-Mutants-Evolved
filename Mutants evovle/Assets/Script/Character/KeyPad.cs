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

    // Start is called before the first frame update
    void Start()
    {
        keypad = false;
    }

    void Update()
    {
        if (correct == true)
        {
            exit.text = "Press Esc";

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
        print("test");
    }

    public void Execute()
    {
        if (ans.text == answer)
        {
            ans.text = "ACCEPTED";            
            correct = true;
        }
        else
        {
            ans.text = "INCORRECT!";
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

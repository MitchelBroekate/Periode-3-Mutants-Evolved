using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeyPad : MonoBehaviour   
{
    public bool keypad;
    public bool correct;
    public Text ans;
    public string answer = "1234";
    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        keypad = false;
        correct = false;
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
            animator.SetBool("Dooropen", true);
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

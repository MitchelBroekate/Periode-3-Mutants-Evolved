using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Conversationmanager : MonoBehaviour
{
    public bool constart;
    public bool conbool;
    public bool conend;
    public bool confirst;
    public int questint;
    public int posind;
    public int negind;
    public int questionind;
    public int limit;
    public TMP_Text pos;
    public TMP_Text neg;
    public TMP_Text npc;
    public TMP_Text quest;
    public Conversation conversation;
    public GameObject[] buttons;
    public GameObject pressesc;
    public Animator animator;
    public Raycast raycast;
    // Start is called before the first frame update
    void Start()
    {
        posind = 0;
        negind = 0;
        questint = 0;
        constart = false;
        conbool = false;
        pressesc.SetActive(false);
        raycast.keyCard.SetActive(false);
       
    }

    // Update is called once per frame
    void Update()
    {
        if (confirst == false)
        {
            npc.text = conversation.questions[questionind];
           
        }
        
        pos.text = conversation.anwsers[posind];
        neg.text = conversation.anwsers[negind];
        quest.text = conversation.quests[questint];

        if (confirst == true)
        {
            npc.text = conversation.anwsers[posind];
            for (var i = 0; i < buttons.Length; i++)
            {
                buttons[i].SetActive(false);
            }
            if (Input.GetMouseButton(0))
            {
                confirst = false;
                Pos();
                for (var i = 0; i < buttons.Length; i++)
                {
                    buttons[i].SetActive(true);
                }
            }
        }
        if (conbool == true && constart == false)
        {
            
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                conbool = false;
                questint += 1;
                conend = true;
                raycast.keyCard.SetActive(true);
            }
        }
        if(conbool == true)
        {
            animator.SetBool("conbool", true);
        }
        if (conend == true)
        {
            animator.SetBool("conend", true);
        }
    }
    public void Pos()
    {
        questionind = posind;
        posind *= 2;
        posind += 1;
        negind = posind;
        negind += 1;
        if (posind > limit)
        {
            After();
        }
        Afterstart();
    }
    public void Neg()
    {
        questionind = negind;
        negind *= 2; 
        negind += 2;
        posind = negind;
        posind -= 1;
        if (posind > limit)
        {
            After();
        }
        Afterstart();
    }
    public void Afterstart()
    {
        confirst = false;
    }
    public void After()
    {
        pressesc.SetActive(true);
        for (var i = 0; i < buttons.Length; i++)
        {
            buttons[i].SetActive(false);
        }
        constart = false;
        posind = 0;
        negind = 0;
    }
}


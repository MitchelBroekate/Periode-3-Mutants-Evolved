using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Conversationmanager : MonoBehaviour
{
    public bool constart;
    public bool conbool;
    public bool conend;
    public int questint;
    public int questionnumber;
    public int questionfactor;
    public int posint;
    public int negint;
    public TMP_Text pos;
    public TMP_Text neg;
    public int npcint;
    public TMP_Text npc;
    public TMP_Text quest;
    public Conversation conversation;
    public GameObject[] buttons;
    public GameObject pressesc;
   
    // Start is called before the first frame update
    void Start()
    {
        posint = 0;
        negint = 1;
        npcint = 0;
        questionnumber = 0;
        questionfactor = 2;
        questint = 0;
        constart = false;
        conbool = false;
        pressesc.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        npc.text = conversation.questions[npcint];
        pos.text = conversation.anwsers[posint];
        neg.text = conversation.anwsers[negint];
        quest.text = conversation.quests[questint];
        if (conbool == true && constart == false)
        {
            for (var i = 0; i < buttons.Length; i++)
            {
                buttons[i].SetActive(false);
            }
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                conbool = false;
                conend = true;
                questint += 1;
            }
        }
    }
    public void Pos()
    {
        posint += questionfactor;
        negint += questionfactor;
        questionfactor *= 2;
        
    }
    public void Neg()
    {
        posint += questionfactor;
        negint += questionfactor;
        questionfactor *= 2;
        questionfactor += 1;
        
    }
    public void After()
    {
        pressesc.SetActive(true);
       
        constart = false;
    }
}


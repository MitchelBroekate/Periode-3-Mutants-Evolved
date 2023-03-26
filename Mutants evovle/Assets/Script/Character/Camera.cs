using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    // concam = conversationcamera
    // Conversationmanager is nodig om de camera switch te laten werken
    public Conversationmanager conman;
    public Camera cam;
    public Camera concam;
    // Start is called before the first frame update
    void Start()
    {
        cam.enabled = true;
        concam.enabled = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        
        
        if (conman.conbool == false)
        {
            // zet hier de code in die voor het draaien van de camera zorgt (RO)
            cam.enabled = true;
            concam.enabled = false;
            Cursor.lockState = CursorLockMode.Locked;
        }

        if (conman.conbool == true)
        {
            cam.enabled = false;
            concam.enabled = true;
            Cursor.lockState = CursorLockMode.Confined;
        }

    }
}

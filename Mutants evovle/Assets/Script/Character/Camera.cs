using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    //RO
    // concam = conversationcamera
    // Conversationmanager is nodig om de camera switch te laten werken
    public Conversationmanager conman;
    public Camera cam;
    public Camera concam;

    //Ryan
    public float RotationSpeed = 1;
    public Transform Target;
    public Transform Player;
    public float mouseX;
    public float mouseY;
    // Start is called before the first frame update
    void Start()
    {
        //RO
        cam.enabled = true;
        concam.enabled = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        //Ryan
        mouseX += Input.GetAxis("Mouse X") * RotationSpeed;
        mouseY -= Input.GetAxis("Mouse Y") * RotationSpeed;
        mouseY = Mathf.Clamp(mouseY, -35, 60);

        transform.LookAt(Target);

        Target.rotation = Quaternion.Euler(mouseY, mouseX, 0);
        Player.rotation = Quaternion.Euler(0, mouseX, 0);

        //RO
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

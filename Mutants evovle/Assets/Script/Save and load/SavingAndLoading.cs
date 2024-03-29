using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SavingAndLoading : MonoBehaviour
{
    public Transform player;
    public Transform[] checkPoints;
    public float poss;
    
    public void Start()
    {


        if (PlayerPrefs.HasKey("xCords"))
        {
            poss = PlayerPrefs.GetFloat("xCords");
            if (poss != -1.24f)
            {
                RestorePosition();
            }
        }
        else
        {
            StorePosition(0);
        }

    }

    public void RestorePosition()
    {
        Vector3 oldPos = new Vector3();
        oldPos.x = PlayerPrefs.GetFloat("xCords");
        oldPos.y = PlayerPrefs.GetFloat("yCords");
        oldPos.z = PlayerPrefs.GetFloat("zCords");
        player.transform.position = oldPos;
    }

    public void StorePosition(int indexOfTrigger)
    {
        PlayerPrefs.SetFloat("xCords", checkPoints[indexOfTrigger].position.x);
        PlayerPrefs.SetFloat("yCords", checkPoints[indexOfTrigger].position.y);
        PlayerPrefs.SetFloat("zCords", checkPoints[indexOfTrigger].position.z);
    }
}

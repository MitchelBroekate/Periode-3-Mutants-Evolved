using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundRespawn : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.transform.tag == "player")
        {
            other.gameObject.GetComponent<SavingAndLoading>().RestorePosition();
        }

    }
}
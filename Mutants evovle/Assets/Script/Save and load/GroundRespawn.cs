using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundRespawn : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        other.gameObject.GetComponent<SavingAndLoading>().RestorePosition();
    }
}
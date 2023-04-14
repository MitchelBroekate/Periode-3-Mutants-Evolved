using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Triggers : MonoBehaviour
{
    public int indexInArray;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.transform.tag == "player")
        {
            other.gameObject.GetComponent<SavingAndLoading>().StorePosition(indexInArray);
        }
    }
}

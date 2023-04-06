using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Triggers : MonoBehaviour
{
    public int indexInArray;

    private void OnTriggerEnter(Collider other)
    {
        other.GetComponent<SavingAndLoading>().StorePosition(indexInArray);
    }
}

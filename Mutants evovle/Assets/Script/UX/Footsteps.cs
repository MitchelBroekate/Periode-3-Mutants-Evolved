using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Footsteps : MonoBehaviour
{
    public AudioSource footstepsound;
    public Animator animator;

    private void Update()
    {
        if (this.animator.GetCurrentAnimatorStateInfo(0).IsName("Walk"))
        {
            footstepsound.enabled = true;
        }
        else
        {
            footstepsound.enabled = false;
        }
    }
}

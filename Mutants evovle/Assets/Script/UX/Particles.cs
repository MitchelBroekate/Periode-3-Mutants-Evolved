using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Particles : MonoBehaviour
{
    public ParticleSystem particle;
    public AudioSource sfx;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (particle.particleCount > 0)
        {
            sfx.enabled = true;
        }
        else
        {
            sfx.enabled = false;
        }
    }
}

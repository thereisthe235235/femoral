using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pewSound : MonoBehaviour
{
    private AudioSource boltadio;
    public AudioClip firingSound;

    // Start is called before the first frame update
    void Start()
    {
        boltadio = GetComponent<AudioSource>();
        
    }

    // Update is called once per frame
    void Update()
    {
         boltadio.PlayOneShot(firingSound, 1.0f);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
public float horizontalinput;
public float speed = 10.0f;
public float xrange = 43;
public float inventory = 0;

 private AudioSource boltadio;
public AudioClip firingSound;

public Transform blaster;
public GameObject bolt;
public GameManager gameManager;

    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        boltadio = GetComponent<AudioSource>();
    }

 
    void Update()
    {
        horizontalinput = Input.GetAxis("Horizontal");

        transform.Translate(Vector3.right * horizontalinput * Time.deltaTime * speed);

        if (transform.position.x > -xrange )
        {
            transform.position = new Vector3(-xrange,transform.position.y, transform.position.z);
        }
        if (transform.position.x < xrange )
        {
            transform.position = new Vector3(xrange,transform.position.y, transform.position.z);
        }

        if(Input.GetKeyDown(KeyCode.Space) && gameManager.isGameOver == false)
        {
            Instantiate(bolt, blaster.transform.position, bolt.transform.rotation);
            boltadio.PlayOneShot(firingSound, 1.0f);
            
        }
    }
    


}

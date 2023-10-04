using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
public float horizontalinput;
public float speed = 10.0f;
public float xrange = 43;

public Transform blaster;
public GameObject bolt;
    void Start()
    {
    
        
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

        if(Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(bolt, blaster.transform.position, bolt.transform.rotation);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
public float horizontalinput;
public float speed;
    void Start()
    {
    
        
    }

 
    void Update()
    {
        horizontalinput = Input.GetAxis("Horizontal");

        transform.Translate(Vector3.right * horizontalinput * Time.deltaTime);
    }
}

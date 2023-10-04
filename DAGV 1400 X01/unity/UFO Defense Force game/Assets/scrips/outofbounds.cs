using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class outofbounds : MonoBehaviour
{
    public float topbounds = 200.0f;
    public float bottombounds = -200.0f;
    // Start is called before the first frame update
void Awake()
{
    //Time.timeScale = 1;
}

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > topbounds)
        {
           Destroy(gameObject); 
        }
        else if (transform.position.z < bottombounds)
        {
            Debug.Log("Game Over!");
            Destroy(gameObject);
        
        }
    }
   
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup_item : MonoBehaviour
{
    public float NumOfpU = 0.0f;
    public float PUspeed = 5.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.back * Time.deltaTime * PUspeed);
    }
    
    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
    }
}

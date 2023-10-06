using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner_for_pickup : MonoBehaviour
{
    public Transform pickup_spawner;
    public GameObject pickup;
    private float SpawnRate = 5.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        SpawnRate = SpawnRate + 1;
       
        if ( SpawnRate > 10 )
        {
        Instantiate(pickup, pickup_spawner.transform.position, pickup.transform.rotation);
        SpawnRate = 0;
        }
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pick_up_spawner : MonoBehaviour
{
    public GameObject[] pickup;
    
    private float spawnRangeX = 40.0f;

    private float spawnPosZ = 40.0f;

    private float startDelay = 4.0f;

    private float spawnInterval = 5.5f;

    void Start()
    {
      
      InvokeRepeating("SpawnRandomUFO", startDelay, spawnInterval);

    }

    





    
    // Update is called once per frame
    void Update()
    {
   
    }
    void SpawnRandomUFO()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX,spawnRangeX),0,spawnPosZ);
        int ufoindex = Random.Range(0,pickup.Length); 
        Instantiate(pickup[ufoindex],spawnPos, pickup[ufoindex].transform.rotation);
    }

}

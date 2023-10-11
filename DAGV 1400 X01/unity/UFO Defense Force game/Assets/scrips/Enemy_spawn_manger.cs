using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_spawn_manger : MonoBehaviour
{
    public GameObject[] ufoPrefabs;
    
    private float spawnRangeX = 40.0f;

    private float spawnPosZ = 40.0f;

    private float startDelay = 2.0f;

    private float spawnInterval = 1.5f;

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
        int ufoindex = Random.Range(0,ufoPrefabs.Length); 
        Instantiate(ufoPrefabs[ufoindex],spawnPos, ufoPrefabs[ufoindex].transform.rotation);
    }

}



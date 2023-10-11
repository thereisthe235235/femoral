using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_spawn_manger : MonoBehaviour
{
    public GameObject[] ufoPrefabs;
    
    private float spawnRangeX = 20.0f;

    private float spawnPosZ = 20.0f;







    
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.S))
        {
          Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX,spawnRangeX),0,spawnPosZ);
          int ufoindex = Random.Range(0,ufoPrefabs.Length); 
          Instantiate(ufoPrefabs[ufoindex],spawnPos, ufoPrefabs[ufoindex].transform.rotation);
        }
    }
}

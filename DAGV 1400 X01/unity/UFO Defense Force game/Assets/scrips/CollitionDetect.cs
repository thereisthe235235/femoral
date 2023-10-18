using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollitionDetect : MonoBehaviour
{

public ScoreManger scoreManger; 

public int scoreToGive;
private AudioSource setexpode;
public AudioClip explode;

void Start()
{
   scoreManger = GameObject.Find("ScoreManager").GetComponent<ScoreManger>();
   setexpode = GetComponent<AudioSource>();
}



 void OnTriggerEnter(Collider other)
 {
    scoreManger.IncreaseScore(scoreToGive);
    setexpode.PlayOneShot(explode, 1.0f);
    Destroy(gameObject); //destroys game object
    Destroy(other.gameObject); // destryis the other gameobject
   
 }
}

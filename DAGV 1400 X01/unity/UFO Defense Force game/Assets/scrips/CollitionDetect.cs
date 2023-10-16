using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollitionDetect : MonoBehaviour
{

public ScoreManger scoreManger; 

public int scoreToGive;

void Start()
{
   scoreManger = GameObject.Find("ScoreManager").GetComponent<ScoreManger>();

}



 void OnTriggerEnter(Collider other)
 {
    scoreManger.IncreaseScore(scoreToGive);
    Destroy(gameObject); //destroys game object
    Destroy(other.gameObject); // destryis the other gameobject
 }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollitionDetect : MonoBehaviour
{
 void OnTriggerEnter(Collider other)
 {
    Destroy(gameObject); //destroys game object
    Destroy(other.gameObject); // destryis the other gameobject
 }
}

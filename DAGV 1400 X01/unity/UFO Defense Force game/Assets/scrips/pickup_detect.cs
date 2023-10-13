using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class pickup_detect : MonoBehaviour
{
   private float pickup_score = 0f;
   void Start()
    {
    Debug.Log("Your score: ");
    }


   void OnTriggerEnter(Collider collision)
   {
      if (collision.gameObject.name == "player")
      {
         pickup_score = pickup_score + 1;
         Debug.Log("Your score: " + pickup_score);
         Destroy(gameObject);
      }
     

 }


}


using System.Collections;
using UnityEngine;

public class DestroyBehavior : MonoBehaviour
{
    public float secounds = 1;
    private WaitForSeconds wfsobj;
    
    IEnumerator Start()
    {
        wfsobj = new WaitForSeconds(secounds);
        yield return wfsobj;
        Destroy(gameObject);
    }

   
}

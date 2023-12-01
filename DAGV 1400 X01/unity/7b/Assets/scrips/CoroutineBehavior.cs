using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

public class CoroutineBehavior : MonoBehaviour
{
    public UnityEvent startEvnt, startCountEvent, repeatCountEvent, endCountEvent, repeatUntilFalseEvent;

    public bool canRun;
    public IntData counterNum;
    public float secounds = 3.0f;
    private WaitForSeconds wfsobj;
    private WaitForFixedUpdate wffuObj;
   
    public bool canRun
    {
        get => canRun;
        set => canRun = value;
    }


    public void Start()
    {
        wfsobj = new WaitForSeconds(secounds);
        wffuObj = new WaitForFixedUpdate();
        startCountEvent.Invoke();
    }

   public void StartCounting()
   {
        StartCoroutine(Counting());

   }


    private IEnumerator Counting()
    {

        startCountEvent.Invoke();
        yield return wfsobj;
        
        while (counterNum.value > 0)
        {
            repeatCountEvent.Invoke();
            counterNum.value--;
            yield  return wfsobj;

        }
        endCountEvent.Invoke();
    }

    public void StartRepeatUntilFalse()
    {
        canRun = true;
        StartCoroutine(RepeatUntelFalse());

    }

    private IEnumerator RepeatUntelFalse()
    {
        while (canRun)
        {
        yield return wfsobj;
        }
    }
}

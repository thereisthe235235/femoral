using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MonoEventsBehavior : MonoBehaviour
{
    public UnityEvent startEvent, awakeEvent, disableEvent;

    private void Awake()
    {
        awakeEvent.Invoke();
    }

    void Start()
    {
        startEvent.Invoke();
    }


    void Update()
    {
         disableEvent.Invoke();
    }
}

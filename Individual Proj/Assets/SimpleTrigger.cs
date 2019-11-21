using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SimpleTrigger : MonoBehaviour
{

    public Rigidbody triggerBody; 
    public UnityEvent onTriggerEnter;
    public UnityEvent OnTriggerExitEvent;


    void OnTriggerEnter(Collider other){
        //do not trigger if there's no trigger target object
        if (triggerBody == null) return;

        //only trigger if the triggerBody matches
        var hitRb = other.attachedRigidbody;
        if (hitRb == triggerBody){
            onTriggerEnter.Invoke();
        }
    }
    void OnTriggerExit(Collider other)
    {
        OnTriggerExitEvent.Invoke();
    }

}

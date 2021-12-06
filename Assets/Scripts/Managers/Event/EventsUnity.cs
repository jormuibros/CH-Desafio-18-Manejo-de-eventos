using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EventsUnity : MonoBehaviour
{
    [SerializeField] private UnityEvent myTrigger;
    private void OnTriggerEnter(Collider other)
    {
        
        if(other.gameObject.tag == "Player")
        {
            Debug.Log("HEROE");
            myTrigger.Invoke();
        }
    }
}

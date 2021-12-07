using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SwitchTorches : MonoBehaviour
{
    [SerializeField] private UnityEvent onSwitchTrap;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.CompareTag("Player"));
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("TORCHES OFF");
            onSwitchTrap?.Invoke();
        }
    }
}

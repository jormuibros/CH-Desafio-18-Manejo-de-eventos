using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateWall : MonoBehaviour
{
    [SerializeField] private GameObject Wall;
    public void Activate()
    {
        Wall.SetActive(true);
    }
    public void ActivateShepere()
    {
        Debug.Log("Esfera");
    }
}

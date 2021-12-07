using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightsController : MonoBehaviour
{
    
    [SerializeField]  private bool  isActive = true;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      
    }

       public void SetActiveTorches(bool status)
    {
        isActive = status;
        Debug.Log("APAGADO");
    }

}

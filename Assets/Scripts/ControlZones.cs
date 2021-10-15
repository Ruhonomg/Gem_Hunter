using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlZones : MonoBehaviour
{
    public GameObject gameManager;


    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Door")
        {
            other.gameObject.GetComponent<Door>().StartEffect();
        }
        
    }
}

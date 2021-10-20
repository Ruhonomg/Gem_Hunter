using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest : MonoBehaviour
{    
    public GameObject effectChest;
    public Transform effectChestTransform;
   
    public GameObject effectEnergy;
    public Transform effectEnergyTransform;

    void Start()
    {
      
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            Destroy(gameObject);
            Instantiate(effectChest, effectChestTransform);
        }

        if(other.tag == "Player")
        {
            Destroy(gameObject);
        }
      
    }
    
}

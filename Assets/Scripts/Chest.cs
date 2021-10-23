using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest : MonoBehaviour
{    
    public GameObject effectChest;
    public Transform effectChestTransform;

    public GameObject GameManager;

    void Start()
    {
      
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            GameManager.GetComponent<GameManager>().AddPoint();
            Instantiate(effectChest, effectChestTransform);
            Destroy(gameObject);
        }
      
    }
    
}

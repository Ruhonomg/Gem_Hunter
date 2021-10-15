using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
   public GameObject effect1Preafb;
   public Transform efect1Position;
   
   public GameObject effect2Preafb;
   public Transform efect2Position;
  
   public GameObject effect3Preafb;
   public Transform efect3Position;
   
   public GameObject effect4Preafb;
   public Transform efect4Position;
  
   public GameObject effect5Preafb;
   public Transform efect5Position;
    
    private bool isOpen;

    private void Start()
    {
        isOpen = false;
    }

    public void StartEffect()
    {
        if (isOpen == false)
        {
            isOpen = true;
            Instantiate(effect1Preafb, efect1Position);
            Instantiate(effect2Preafb, efect2Position);
            Instantiate(effect3Preafb, efect3Position);
            Instantiate(effect4Preafb, efect4Position);
            Instantiate(effect5Preafb, efect5Position);
        }
    }
}

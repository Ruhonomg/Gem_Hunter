using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StarterAssets;

public class FX : MonoBehaviour
{
    public ThirdPersonController player;
    
    void Update()
    {
        if (player.isMoving == true)
        {
            GetComponent<AudioManager>().PlayStep();
        }
    }
}

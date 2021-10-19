using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest : MonoBehaviour
{    
    public GameObject effectChest;
    public Transform effectTransform;

    private bool triggered;
    private AudioSource clip;

    void Awake ()
    {
        audioSource = gameObject.GetComponent<AudioSource>();
    }

    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            clip.Play();
            Destroy(gameObject);
            Instantiate(effectChest, effectTransform);
        }
    }
}

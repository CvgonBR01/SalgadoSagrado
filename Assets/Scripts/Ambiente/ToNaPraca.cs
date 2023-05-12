using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToNaPraca : MonoBehaviour
{

    private BoxCollider2D coll;
    [SerializeField] public AudioSource AudioPraca;

    void Start()
    {
        coll = GetComponent<BoxCollider2D>();
    }

 
    private void OnTriggerEnter2D(Collider2D coll)
    {

        if (coll.gameObject.tag == "Player")
        {
            AudioPraca.enabled = true;
        }
        
    }
}

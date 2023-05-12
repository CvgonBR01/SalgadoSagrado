using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToCorridaFinal : MonoBehaviour
{
    
    private BoxCollider2D coll;
    [SerializeField] public AudioSource Audiofim;

    void Start()
    {
        coll = GetComponent<BoxCollider2D>();
    }


    private void OnTriggerEnter2D(Collider2D coll)
    {

        if (coll.gameObject.tag == "Player")
        {
            Audiofim.enabled = true;
        }

    }
}

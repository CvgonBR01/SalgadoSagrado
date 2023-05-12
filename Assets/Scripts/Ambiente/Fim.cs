using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fim : MonoBehaviour
{


    private BoxCollider2D coll;
    [SerializeField] public AudioSource FimSound;
    // Start is called before the first frame update
    void Start()
    {
        coll = GetComponent<BoxCollider2D>();
    }

   
    private void OnTriggerEnter2D(Collider2D coll)
    {
       
        if (coll.gameObject.tag == "Player")
        {
            FimSound.Play();

        }


    }
}

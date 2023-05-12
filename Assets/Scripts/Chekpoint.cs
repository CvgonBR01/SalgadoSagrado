using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chekpoint : MonoBehaviour
{

   

    private Vector3 Respawn;

    //public Respawn pointupdate;

    [SerializeField] public AudioSource Reespawn;
    
    //public GameObject currentCheck;

    //public GameObject dano;

    private BoxCollider2D coll;

    // Start is called before the first frame update
    void Start()
    {
        //pega o componente BoxCollider
        coll = GetComponent<BoxCollider2D>();
        
        
        Respawn = transform.position;
    }
  
    private void OnTriggerEnter2D(Collider2D coll)
    {
        
        if(coll.gameObject.tag == "Dano")
        { 
            transform.position = Respawn;
            Reespawn.Play();
        }
        else if(coll.gameObject.tag == "Check")
        {
            Respawn = transform.position;
            
            
        }
    }   
}

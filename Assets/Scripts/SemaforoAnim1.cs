using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SemaforoAnim1 : MonoBehaviour
{

    [SerializeField] public AudioSource CheckPoint;
    private Animator anim;

    private BoxCollider2D coll;
    // Start is called before the first frame update
    void Start()
    {
        //pega o componente BoxCollider
        coll = GetComponent<BoxCollider2D>();
        anim = GetComponent<Animator>();
    }


  
    private void OnTriggerEnter2D(Collider2D coll)
    {
        if (anim.GetBool("checked") == false && coll.gameObject.tag == "Player")
        {
            CheckPoint.Play();
        }
        if (coll.gameObject.tag == "Player")
        {
            anim.SetBool("checked", true);
            
        }
        
        
    }
}

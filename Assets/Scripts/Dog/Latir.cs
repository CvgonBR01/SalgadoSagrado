using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Latir : MonoBehaviour
{


    //latido
    [SerializeField] private AudioSource barkSoundEffect;
    
    private float cooldown = 8f;

    // Update is called once per frame
    void Update()
    {
        //latir a cada 8 segundos
        cooldown -= Time.deltaTime;
        //Debug.Log(cooldown);
        if (cooldown < 0)
        {
            barkSoundEffect.Play();
            cooldown = 8f;
        }
        
    }
}

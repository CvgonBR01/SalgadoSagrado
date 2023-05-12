using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Latir : MonoBehaviour
{
    //referencia para alterar o lado do sprite
    private SpriteRenderer sprite;
    //referencia rigidbody
    private Rigidbody2D rig;
    //latido
    [SerializeField] private AudioSource barkSoundEffect;

    [SerializeField] private int speed;
    private float cooldown = 6f;
    [SerializeField] private float tempo;

    //troca de lado
    private float troca = 1.5f;


    //chegou na praca
    [SerializeField] private AudioSource SaiDaPraca;
    [SerializeField] private AudioSource PossoLatir;
    private bool LatidoNaPraca = false;

    private void Start()
    {
        troca = tempo;
        rig = GetComponent<Rigidbody2D>();
        sprite = GetComponent<SpriteRenderer>();
    }
    void Update()
    {
        if (PossoLatir.enabled == true && SaiDaPraca.enabled == false)
        {
            LatidoNaPraca = true;
            

        } else
        {
            LatidoNaPraca = false;
      
        }
        //latir a cada 8 segundos
        cooldown -= Time.deltaTime;
        //Debug.Log(cooldown);
        if (cooldown < 0  && LatidoNaPraca == true)
        {
            barkSoundEffect.Play();
            cooldown = 6f;
            
        }
        
        
        troca -= Time.deltaTime;
        
        if (troca >= 0f)
        {
            rig.velocity = new Vector2(1 * speed, rig.velocity.y);
            sprite.flipX = true;
        }
        else
        {
            rig.velocity = new Vector2(- 1 * speed, rig.velocity.y);
            sprite.flipX = false;
        }
        if (troca <= -tempo)
        {
            troca = tempo;
        }
        


    }


   
}

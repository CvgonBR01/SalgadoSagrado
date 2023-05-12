using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{


    //referencia para o som
    [SerializeField] public AudioSource footstepsSound;
    [SerializeField] private AudioSource jumpSoundEffect;

    //referencia rigidbody
    private Rigidbody2D rig;

    //referencia para alterar o lado do sprite
    private SpriteRenderer sprite;

    //referencia para alterar as animacoes
    private Animator anim;

    //estados da animacao
    private enum MovementState { idle, running, jumping, cai }

    //verificacao se o player esta no chao
    private BoxCollider2D coll;
    [SerializeField] private LayerMask jumpableGround;

    //input horizontal
    private float Hor;

    //input de pulo
    private bool Jump;
    [SerializeField]
    //velocidade e velocidade de pulo
    private float speed, Jspeed;

    [SerializeField]
    //ponto de origem do raycast e distancia do rayccast
    private float Ray, Dis;

    [SerializeField]
    //quais layers o raycast atinge
    private LayerMask layer_mask;

        
    private void Start()
    {
        //pega o componente do raycast
        rig = GetComponent<Rigidbody2D>();
        //pega o componente BoxCollider
        coll = GetComponent<BoxCollider2D>();
        //Pega componentes para animar
        sprite = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
        //Respawn = transform.position;
    }


    private void Update()
    {
        //pega os inputs de movimento e pulo
        Hor = Input.GetAxis("Horizontal");
        //da pra usar Input.GetButtonDown("Jump")
        if (Input.GetButtonDown("Jump") && IsGrounded()) Jump = true;
        UpdateAnimationState();
        FootStepsSoundEffect();
    }

    private void FootStepsSoundEffect()
    {
        if ((Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.RightArrow)) && IsGrounded())
        {
            footstepsSound.enabled = true;
        }
        else
        {
            footstepsSound.enabled = false;
        }
    }

    private void FixedUpdate()
    {
       
        if (Hor != 0)
        {
            rig.velocity = new Vector2(Hor * speed, rig.velocity.y);
           
        }


        //quando aperta o botao de pulo
        if (Jump == true)
        {
            

            RaycastHit2D hit = Physics2D.Raycast(transform.position - transform.up * Ray, Vector2.down, 1000, layer_mask);
            //desenha na tela pra fazer debugging
            //Debug.DrawRay(transform.position - transform.up * Ray, Vector2.down, Color.red, 1f);


            if (hit.collider != null)
            {

              if (hit.distance < Dis)
             {
                    
                    //pulo
                    rig.AddForce(new Vector2(0, Jspeed), ForceMode2D.Impulse);
                    //Snd pulo
                    jumpSoundEffect.Play();
                }
                //Debug.Log(hit.distance);
            }

           
            //reseta o input
            //no FixedUpdate() e nao no Update pra nao ser resetado antes do pulo acontecer
            Jump = false;
           
        }

    }

   private void UpdateAnimationState()
    {
        MovementState state;
        //Update de anima��o

        

        //Update andar
        if (Hor > 0f)
        {
            state = MovementState.running;
            //Altera o lado do sprite de acordo com o seu movimento
            sprite.flipX = true;
           

        } else if (Hor < 0f)
        {
            state = MovementState.running;
            sprite.flipX = false;
          
        } else
        {
            state = MovementState.idle;

        }

        //Update Pulo
        if (rig.velocity.y > .1f)
        {
            state = MovementState.jumping;
        }
        else if (rig.velocity.y < -.1f)
        {
           
            state = MovementState.cai;
        }

        anim.SetInteger("state", (int)state);
        
    }

    private bool IsGrounded()
    {
        return Physics2D.BoxCast(coll.bounds.center, coll.bounds.size, 0f, Vector2.down, .1f, jumpableGround);
    }
   
  

}

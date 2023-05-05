using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public GameObject bullet, spawnerBulletPos;
    //referencia rigidbody
    private Rigidbody2D rig;

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
    }


    private void Update()
    {
        //pega os inputs de movimento e pulo
        Hor = Input.GetAxis("Horizontal");
        //da pra usar Input.GetButtonDown("Jump")
        if (Input.GetKeyDown(KeyCode.Space)) Jump = true;


        //Chama a função de instanciar as bullets
        SpawnBullet();
        


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
                }
            }

            //reseta o input
            //no FixedUpdate() e nao no Update pra nao ser resetado antes do pulo acontecer
            Jump = false;
        }
    }

    private void SpawnBullet() {
        //Instanciar a balla do estilingue de acordo com a posição do mouse
        
        //Pega a posição
        /*
        Vector3 mousePos = Input.mousePosition;
        mousePos = Camera.main.ScreenToWorldPoint(mousePos);
        Vector2 direction = new Vector2(mousePos.x - transform.position.x, mousePos.y - transform.position.y);
        transform.up = direction;
        */


        
        if(Input.GetMouseButtonDown(0)) {
            //Instancia no mouse
            Instantiate(bullet, spawnerBulletPos.transform.position, this.gameObject.transform.rotation);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 8)
        {
            Destroy(gameObject);
        }
    }

}

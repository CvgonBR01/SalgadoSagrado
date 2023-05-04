using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamerePosition : MonoBehaviour
{
    //referencia do transform do jogador
    [SerializeField]
    private Transform player;

    //diferenca entre a posicao da camera e do jogador
    [SerializeField]
    private Vector3 pos;
    
    private void Update()
    {
        //atualiza a posicao da camera
        transform.position = player.position + pos;
    }
}

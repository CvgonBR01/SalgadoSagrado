using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    //faz a camera seguir o player, mas se o player rotar o Z, ela nao rota junto
    [SerializeField] private Transform player;
    [SerializeField] private float offset;
 
    private void Update()
    {
        //transform.position = new Vector3(player.position.x, player.position.y+offset, transform.position.z);
        transform.position = new Vector3(player.position.x,offset, transform.position.z);
    }
}

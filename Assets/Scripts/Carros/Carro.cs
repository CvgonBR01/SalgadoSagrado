using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Carro : MonoBehaviour
{
    private Rigidbody2D rig;
    [SerializeField] private int speed;

    [SerializeField] private float TimeLife;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
        StartCoroutine(destroyCar());
    }

    IEnumerator destroyCar()
    {
        yield return new WaitForSeconds(TimeLife);
        Destroy(gameObject);
    }
}

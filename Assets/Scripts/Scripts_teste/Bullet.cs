using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    bool isLeft;
    bool direction;
    //true = left | false = right

    // Start is called before the first frame update
    void Start()
    {
        if (isLeft == true)
        {
            direction = true;
        } else
        {
            direction = false;
        }

    }

    // Update is called once per frame
    void Update()
    {
        if (direction)
        {
            transform.Translate(Vector2.left * 10 * Time.deltaTime);
            StartCoroutine(destroyBullet());
        } else
        {
            transform.Translate(Vector2.right * 10 * Time.deltaTime);
            StartCoroutine(destroyBullet());
        }
        
    }

    IEnumerator destroyBullet()
    {
        yield return new WaitForSeconds(2.5f);
        Destroy(gameObject);
    }
}

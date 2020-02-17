using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectile : MonoBehaviour
{
    public float speed;
    public float lifeTime;
    
    private void Start()
    {
        Invoke("DestroyProjectile", lifeTime);
    }

    private void Update()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime);

      
    }

    void DestroyProjectile()
    {
       Destroy(gameObject);
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.tag=="Enemy"){
            Destroy(col.gameObject);
        }
    }
}

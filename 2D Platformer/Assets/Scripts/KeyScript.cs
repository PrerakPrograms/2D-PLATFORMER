using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyScript : MonoBehaviour
{
    public bool hasKey;
   
    public SpriteRenderer keysprite;
    public BoxCollider2D KeyCollider;

    void Start()
    {
        
    }
    void Update()
    {

    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.tag=="Player"){
            keysprite.sprite = null;
            hasKey = true;
        }
    }
    
}

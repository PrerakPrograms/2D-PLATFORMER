using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyScript : MonoBehaviour
{
    public bool hasKey;
   
    public SpriteRenderer keysprite;

    void Start()
    {
        
    }
    void Update()
    {

    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag=="Player"){
            keysprite.sprite = null;
            hasKey = true;

        }
    }
    
}

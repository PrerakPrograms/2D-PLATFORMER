using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FeetCheck : MonoBehaviour
{
    public GameObject player;
    

    void Start()
    {
        
    }

    // Update is called once per frame
    public void OnTriggerEnter2D(Collider2D other)
    {
       
        if (other.gameObject.CompareTag("Platform"))
        {
            player.transform.parent = other.gameObject.transform;
        }
    }
        public void OnTriggerExit2D(Collider2D other)
    {
       if(other.gameObject.CompareTag("Platform")){
           player.transform.parent = null;
       }
        }
        
    }


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class pickup : MonoBehaviour
{
    
   public int gemscollected;
  
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
   
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            Debug.Log("PickedUP");
            AddScore();
            Destroy(gameObject);
        }
    }
        void AddScore(){
             gemscollected++;
             

        }

    }


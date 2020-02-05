using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class pickup : MonoBehaviour
{
    
  
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
   
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            Debug.Log("PickedUP");
            AddScore();
            Destroy(gameObject);
        }
    }
        void AddScore(){
            GemCounter.gemsamount += 1;
             

        }

    }


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerup_cherry : MonoBehaviour
{
    public SpriteRenderer sp;
    public GameObject pl;
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
            
           StartCoroutine(Powerup());
        }
    }
        IEnumerator Powerup(){
            sp.color = new Color(1, 0, 0, 1);
            pl.GetComponent<PlayerMovement>().PlayerSpeed = 60f;
            GetComponent<SpriteRenderer>().enabled = false;
            GetComponent<Collider2D>().enabled = false;
            yield return new WaitForSeconds(4f);
            sp.color = new Color(255, 255, 255, 255);
           pl.GetComponent<PlayerMovement>().PlayerSpeed = 40f;
           Destroy(this.gameObject);


        }

    }

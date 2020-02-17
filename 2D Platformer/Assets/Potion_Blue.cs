using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Potion_Blue : MonoBehaviour
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
    IEnumerator Powerup()
    {
        sp.color = new Color(0, 150, 255, 255);
        pl.tag = "Untagged";
        GetComponent<SpriteRenderer>().enabled = false;
        GetComponent<Collider2D>().enabled = false;
        yield return new WaitForSeconds(5.5f);
        sp.color = new Color(255, 255, 255, 255);
        pl.tag = "Player";
        Destroy(this.gameObject);


    }
}

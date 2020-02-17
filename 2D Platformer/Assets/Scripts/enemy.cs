using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    public float speed;

    public bool movingRight;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (movingRight)
        {
            transform.Translate(2 * Time.deltaTime * speed, 0, 0);
            transform.localScale = new Vector2(4, 4);
        }
        else
        {
            transform.Translate(-2 * Time.deltaTime * speed, 0, 0);
            transform.localScale = new Vector2(-4, 4);

        }
    }
    void OnTriggerEnter2D(Collider2D trig)
    {
        if(trig.gameObject.CompareTag("TurnPoint")){
        if(movingRight){
            movingRight = false;
        }
        else
        {
            movingRight = true;
        }
        }
    }
}

/*transform.Translate(Vector2.right*speed*Time.deltaTime);
        RaycastHit2D groundcheck = Physics2D.Raycast(groundDetect.position,Vector2.down);
        if (groundcheck.collider == false)
        {
            if (movingRight)
            {
                transform.eulerAngles = new Vector3(0, -180, 0);
                movingRight = false;
            }
        }
        else
        {
            transform.eulerAngles = new Vector3(0, 0, 0);
            movingRight = true;
        }*/

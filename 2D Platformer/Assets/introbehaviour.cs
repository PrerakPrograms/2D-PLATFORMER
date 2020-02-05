using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class introbehaviour : StateMachineBehaviour
{
   Transform player;
    public int rand;
    public float speed = 2.5f;
    Rigidbody2D rb;
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        animator.GetComponent<Rigidbody2D>();
    }

    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        Vector2 target = new Vector2(player.position.x,rb.position.y);
       Vector2 newpos= Vector2.MoveTowards(rb.position,target,speed*Time.fixedDeltaTime);
     
   }

    
    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
       
    }

    
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    
	public CharacterController2D controller;
	float hMove = 0f;
	public float PlayerSpeed = 30f;
    bool jump = false;
    bool crouch = false;
    public Animator anim;
    public GameObject bullet;
    public Transform shotpoint;
    // Start is called before the first frame update
    void Start()
    {
		
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(bullet, shotpoint.position, transform.rotation);
        } 
	hMove = Input.GetAxisRaw("Horizontal") * PlayerSpeed;
		

        if(Input.GetButtonDown("Jump")){
            jump = true;
            anim.SetBool("Jumping",true);
        }
        if (Input.GetButtonDown("Crouch"))
        {
           crouch = true;
          
        }
        else if (Input.GetButtonUp("Crouch"))
        {
            
           crouch = false;

       }
     
        
        anim.SetFloat("Running", Mathf.Abs(hMove));
    }
   public void OnLanding()
    {
        anim.SetBool("Jumping",false);
    }

   public void OnCrouching(bool crouch)
   {
       anim.SetBool("Crouching", crouch);
   }
	void FixedUpdate()
	{
		controller.Move(hMove * Time.fixedDeltaTime, crouch , jump);
        jump = false;
        
	}
}

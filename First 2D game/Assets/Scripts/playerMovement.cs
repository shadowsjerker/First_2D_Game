using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class playerMovement : MonoBehaviour {

	public CharacterController2D controller;

	public Animator animator;

	public float runspeed = 40f;
	
	float horizontalMove = 0f;
	bool jump = false;
	bool crouch = false;

	void Start()
    {
		
    }

	// Update is called once per frame
	void Update () {

		horizontalMove = Input.GetAxisRaw("Horizontal") * runspeed;

		animator.SetFloat("Speed", Mathf.Abs(horizontalMove));

		if(Input.GetButtonDown("Jump"))
        {
			jump = true;
        }

		if(Input.GetButtonDown("Crouch"))
        {
			crouch = true;
        }
		else if(Input.GetButtonUp("Crouch"))
        {
			crouch = false;
        }

		if(Input.GetKey(KeyCode.P) && Input.GetKey(KeyCode.Space))
        {
			GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 150), ForceMode2D.Force);
        }

	}

	void FixedUpdate()
    {
		controller.Move(horizontalMove * Time.fixedDeltaTime, crouch, jump);
		jump = false;
    }

	

}

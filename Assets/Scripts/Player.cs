using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

		private Animator anim;
		private CharacterController controller;

		public float speed = 600.0f;
		public float turnSpeed = 400.0f;
		private Vector3 moveDirection = Vector3.zero;
		public float gravity = 20.0f;
		public float jumpSpeed = 10.0f;
		private float distToGround;
		private bool isGrounded;

		void Start() {
			controller = GetComponent <CharacterController>();
			anim = gameObject.GetComponentInChildren<Animator>();
			distToGround = GetComponent<Collider>().bounds.extents.y;
		}

		bool checkGrounded() {
			return Physics.Raycast(transform.position, -Vector3.up, distToGround + 0.1f);
		}
		
		void Update() {
			if (checkGrounded()) {
				anim.SetBool ("Grounded", true);
				isGrounded = true;
			}else{
				anim.SetBool ("Grounded", false);
				isGrounded = false;
				
			}
			
			moveDirection.x = 0f;
			moveDirection.z = 0f;

			moveDirection += transform.forward * Input.GetAxis("Vertical") * speed;
			Debug.Log("" + moveDirection);

			if(isGrounded){
				if(Input.GetAxis("Vertical") > 0){
					anim.SetInteger("AnimationPar", 1);	  
				}else{
					anim.SetInteger("AnimationPar", 0);	
				}
				
				if(Input.GetButton("Jump")){
					moveDirection.y = jumpSpeed;
					anim.SetInteger("AnimationPar", 2);
				}
			}

			float turn = Input.GetAxis("Horizontal");
			transform.Rotate(0, turn * turnSpeed * Time.deltaTime, 0);
			controller.Move(moveDirection * Time.deltaTime);
			if (!isGrounded){
				moveDirection.y -= gravity * Time.deltaTime;
			}

		}
}

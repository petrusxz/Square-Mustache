using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour {
	public Rigidbody2D rigidbody2D;
	public Transform groundCheck;
	public float groundCheckRadius;
	public LayerMask whatIsGround;
	public bool onGround;

	// Use this for initialization
	void Start () {
		rigidbody2D = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		rigidbody2D.velocity = new Vector2 (3, rigidbody2D.velocity.y);
		onGround = Physics2D.OverlapCircle (groundCheck.position, groundCheckRadius, whatIsGround);

		if (Input.GetMouseButtonDown (0) && onGround) {
			rigidbody2D.velocity = new Vector2 (rigidbody2D.velocity.x, 5);
		}
	}
}

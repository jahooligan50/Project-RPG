using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    private Animator anim;
    private Rigidbody2D rBody;
    private Vector2 moveVector;
    public float moveSpeed;

    // Use this for initialization
    void Start () {
        anim = GetComponent<Animator>();
        rBody = GetComponentInChildren<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        moveVector = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")); //raw axis is on or off, not gradual

        if (moveVector != Vector2.zero)
        {
            anim.SetBool("isWalking", true);
            anim.SetFloat("input_x", moveVector.x);
            anim.SetFloat("input_y", moveVector.y);
        }
        else anim.SetBool("isWalking", false);

        rBody.MovePosition(rBody.position + moveVector * Time.deltaTime * moveSpeed);
	}



}

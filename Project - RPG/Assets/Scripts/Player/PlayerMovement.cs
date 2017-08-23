using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    private Animator anim;
    private Rigidbody2D rBody;
    private Vector2 moveVector;
    private SwingSword sword;
    public float moveSpeed;

    // Use this for initialization
    void Start () {
        anim = GetComponent<Animator>();
        rBody = GetComponent<Rigidbody2D>();
        sword = GetComponentInChildren<SwingSword>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        Move();
        Attack();
    }

    private void Move()
    {
        moveVector = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")); //raw axis is on or off, not gradual?

        if (moveVector != Vector2.zero)
        {
            anim.SetBool("isWalking", true);
            anim.SetFloat("input_x", moveVector.x);
            anim.SetFloat("input_y", moveVector.y);
        }
        else anim.SetBool("isWalking", false);

        rBody.MovePosition(rBody.position + moveVector * Time.deltaTime * moveSpeed);
    }

    private void Attack()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            anim.SetTrigger("isAttacking");
        }
    }

    private void SwordSwitch()
    {
        sword.FlipSwordSwitch();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    private Animator anim;
    private Rigidbody2D rBody;
    private Vector2 moveVector;
    private SwingSword[] swords;
    private SwingSword sword;
    private Direction direction;
    public float moveSpeed;

    // Use this for initialization
    void Start () {
        anim = GetComponent<Animator>();
        rBody = GetComponent<Rigidbody2D>();
        swords = GetComponentsInChildren<SwingSword>();
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
        SetDirection(moveVector);

        if (moveVector != Vector2.zero)
        {
            anim.SetBool("isWalking", true);
            anim.SetFloat("input_x", moveVector.x);
            anim.SetFloat("input_y", moveVector.y);
        }
        else anim.SetBool("isWalking", false);

        rBody.MovePosition(rBody.position + moveVector * Time.deltaTime * moveSpeed);
    }

    private void SetDirection(Vector2 moveVector)
    {
        if(Mathf.Abs(moveVector.x) > Mathf.Abs(moveVector.y))
        {
            if (moveVector.x > 0) direction = Direction.right;
            else direction = Direction.left;
        }
        else
        {
            if (moveVector.y > 0) direction = Direction.up;
            else direction = Direction.down;
        }
        foreach (SwingSword dir in swords)
        {
            if (dir.tag == "up" && direction == Direction.up) sword = dir;
            if (dir.tag == "down" && direction == Direction.down) sword = dir;
            if (dir.tag == "left" && direction == Direction.left) sword = dir;
            if (dir.tag == "right" && direction == Direction.right) sword = dir;
        }
    }

    private void Attack()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            anim.SetTrigger("isAttacking");
        }
    }

    private void SwordSwitchOn()
    {
        sword.FlipSwordSwitchOn();
    }

    private void SwordSwitchOff()
    {
        sword.FlipSwordSwitchOff();
    }

    private enum Direction
    {
        up,
        down,
        left,
        right
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grass : MonoBehaviour {

    private Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        //PlayerMovement player = col.GetComponent<PlayerMovement>(); //for testing grass cuts when walked on.
        SwingSword sword = col.GetComponent<SwingSword>(); //for cutting grass with sword.

        //if (player) anim.SetTrigget("isCut"); //for testing grass cuts when walked on.
        if (sword.GetSwordEnabled()) anim.SetTrigger("isCut"); //for cutting grass with sword.

    }
	



}

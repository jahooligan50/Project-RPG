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
        SwingSword sword = col.GetComponent<SwingSword>(); //for cutting grass with sword.

        if (sword.GetSwordEnabled()) anim.SetTrigger("isCut"); //for cutting grass with sword.

    }
	



}

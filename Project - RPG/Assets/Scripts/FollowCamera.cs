using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour {

    private Transform playerTransform;

	// Use this for initialization
	void Start () {
        playerTransform = GameObject.FindObjectOfType<PlayerMovement>().GetComponentInChildren<Rigidbody2D>().GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update () {
        if (playerTransform)
        {
            transform.position = playerTransform.position + new Vector3 (0,0,-10f);
        }
	}
}

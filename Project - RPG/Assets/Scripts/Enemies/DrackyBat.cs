using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(PlayerMovement))]
public class DrackyBat : MonoBehaviour {

    [SerializeField] Vector3 attackAlertRange = new Vector3(1f,1f,0);
    [SerializeField] float moveSpeed = 1f;
    [SerializeField] Vector3 moveRange = new Vector3(4f, 4f, 0);

    PlayerMovement player;

	// Use this for initialization
	void Start () {
        player = GameObject.FindObjectOfType<PlayerMovement>();
	}
	
	// Update is called once per frame
	void Update () {
        if(Mathf.Abs( (player.transform.position - transform.position).magnitude ) <= attackAlertRange.magnitude)
        {
            FollowPlayer();
        }
        else
        {
            MoveInPattern();
        }
	}

    void FollowPlayer()
    {
        //TODO make follow player
    }

    void MoveInPattern()
    {
        //TODO move in pseudorandom pattern (prefferably in a box range)
    }


}

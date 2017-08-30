using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrackyGizmos : MonoBehaviour {

    DrackyBat dracky;

    void Start()
    {
        dracky = GetComponentInChildren<DrackyBat>();
    }

    void OnDrawGizmos()
    {
        //MoveBox
        Gizmos.color = Color.red;
        Gizmos.DrawWireCube(transform.position, dracky.moveRange);
    }
}

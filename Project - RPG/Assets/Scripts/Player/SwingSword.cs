using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwingSword : MonoBehaviour {

    BoxCollider2D swordCol;

	// Use this for initialization
	void Start () {
        swordCol = GetComponent<BoxCollider2D>();
	}

    public void FlipSwordSwitch()
    {
        swordCol.enabled = !swordCol.enabled;
    }

    public bool GetSwordEnabled()
    {
        return swordCol.enabled;
    }
}

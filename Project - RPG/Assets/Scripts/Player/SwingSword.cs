using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwingSword : MonoBehaviour {

    PolygonCollider2D swordCol;

	// Use this for initialization
	void Start () {
        swordCol = GetComponent<PolygonCollider2D>();
	}

    public void FlipSwordSwitchOn()
    {
        swordCol.enabled = true;
    }

    public void FlipSwordSwitchOff()
    {
        swordCol.enabled = false;
    }

    public bool GetSwordEnabled()
    {
        return swordCol.enabled;
    }
}

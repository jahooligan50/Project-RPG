using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public float moveSpeed;
    public Sprite leftSprite;
    public Sprite rightSprite;
    public Sprite downSprite;
    public Sprite upSprite;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.LeftArrow)) MoveLeft();
        else if (Input.GetKey(KeyCode.RightArrow)) MoveRight();
        else if (Input.GetKey(KeyCode.DownArrow)) MoveDown();
        else if (Input.GetKey(KeyCode.UpArrow)) MoveUp();
	}

    void MoveLeft()
    {
        GetComponent<SpriteRenderer>().sprite = leftSprite;
        transform.Translate(Vector3.left * Time.deltaTime * moveSpeed);
    }

    void MoveRight()
    {
        GetComponent<SpriteRenderer>().sprite = rightSprite;
        transform.Translate(Vector3.right * Time.deltaTime * moveSpeed);
    }

    void MoveDown()
    {
        GetComponent<SpriteRenderer>().sprite = downSprite;
        transform.Translate(Vector3.down * Time.deltaTime * moveSpeed);
    }

    void MoveUp()
    {
        GetComponent<SpriteRenderer>().sprite = upSprite;
        transform.Translate(Vector3.up * Time.deltaTime * moveSpeed);
    }

}

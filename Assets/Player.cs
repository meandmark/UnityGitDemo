using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        Move();
	}

	public void Move() {
        float speed = 10.0f;
        float xMovement = speed * Input.GetAxis("Horizontal") * Time.deltaTime;
        transform.Translate(Vector3.right * xMovement);

        float yMovement = speed * Input.GetAxis("Vertical") * Time.deltaTime;
        transform.Translate(Vector3.up * yMovement);
	}
}

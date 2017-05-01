using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoostJumps : MonoBehaviour {
    public float velocity = 200f;
    public Rigidbody carRB;

	// Use this for initialization
	void Start () {
        carRB = GetComponent<Rigidbody>();
    }
	// Update is called once per frame
	void Update () {
    }

    private void OnCollisionEnter(Collision c) {
        if(c.collider.tag == "Boost") {
            velocity = 50.0f;
            carRB.AddForce(Vector3.up * 50.0f);
        }
    }
}

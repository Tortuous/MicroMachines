using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoostPlank : MonoBehaviour {
    public int strength;
    public float velo = 200f;

	// Use this for initialization
	void Start () {
	}
    void OnCollisionEnter(Collision collision) {
        if (collision.collider.tag == "player")
        {
            collision.collider.GetComponent<Rigidbody>().AddForce(collision.collider.transform.forward * strength);
            velo = 50f;
        }
    }
    void Update () {
	}
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarBumping : MonoBehaviour {
	// Use this for initialization
	void Start () {
		
	}
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter(Collision collider)
    {
        float force = 5000f;

        if (collider.gameObject.tag == "Player")
        {
            Vector3 dir = collider.contacts[0].point - transform.position;
            dir = -dir.normalized;
            GetComponent<Rigidbody>().AddForce(dir * force);
        }
    }
}

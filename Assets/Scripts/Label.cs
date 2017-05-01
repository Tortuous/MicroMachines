using UnityEngine;
using System.Collections;

[RequireComponent (typeof (GUIText))]

public class Label : MonoBehaviour {
 
    public Transform target;
    public Camera cameraToUse;
    public Vector3 offset = Vector3.up;
    public bool clampToScreen = false;
    public float clampBorderSize = 0.05f;
    private Camera cam ;
    private Transform thisTransform;
    private Transform camTransform;
 
	void Start () {
	    thisTransform = transform;
        cam = cameraToUse;
        camTransform = cam.transform;
	}

    void Update() {
        thisTransform.position = cam.WorldToViewportPoint(target.position + offset);
    }
}
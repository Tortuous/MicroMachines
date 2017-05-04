using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarControls : MonoBehaviour {
    public float rotationRange = 1.0f;
    public float maxVelocity = 300.0f;
    public float carSpeed = 10.0f;
    public float brakes = 0.88f;
    public float velo = 200.0f;

    public bool car1;
    public bool car2;
    public bool car3;
    public bool car4;

    public bool track1;
    public bool track2;

    private ParticleEmitter p1;
    private ParticleEmitter p2;
    private Rigidbody carRB;
    private float LeftHorizontalValue;
    private float RightVerticalValue;
    private float LeftHorizontalValue2;
    private float RightVerticalValue2;
    private float gas1;
    private float gas2;
    private float brake1;
    private float brake2;
    private bool downForce;

    void Start() {
        carRB = gameObject.GetComponent<Rigidbody>();
    }
    void OnCollisionStay(Collision other)
    {
        downForce = false;
    }
    void OnCollisionExit(Collision other) {
        downForce = true;
    }

    void FixedUpdate() {
        if(downForce) {
            carRB.AddForce(Vector3.down * velo);
        }

        float LeftHorizontalValue = Input.GetAxis("LeftJoystickHorizontal1");
        float RightVerticalValue = Input.GetAxis("RightJoystickVertical1");
        float LeftHorizontalValue2 = Input.GetAxis("LeftJoystickHorizontal2");
        float RightVerticalValue2 = Input.GetAxis("RightJoystickVertical2");
        float gas1 = carSpeed * Input.GetAxis("RightTrigger1");
        float gas2 = carSpeed * Input.GetAxis("RightTrigger2");
        float brake1 = carSpeed * Input.GetAxis("LeftTrigger1");
        float brake2 = carSpeed * Input.GetAxis("LeftTrigger2");

        if (carRB.velocity.sqrMagnitude > maxVelocity) {
            carRB.velocity *= brakes;
        }

        if (track1) {
            //Buttons that control car 1.
            if (car1) {
                if (Input.GetKey(KeyCode.W)) { //forward keyboard
                    carRB.AddForce(transform.forward * carSpeed);
                }
                if (Input.GetKey(KeyCode.A) || LeftHorizontalValue < -0.5f) { //left
                    gameObject.transform.Rotate(0, -rotationRange, 0);
                }
                if (Input.GetKey(KeyCode.S)) { //backward keyboard
                    carRB.AddForce(-transform.forward * carSpeed);
                }
                if (Input.GetKey(KeyCode.D) || LeftHorizontalValue > 0.5f) { //right
                    gameObject.transform.Rotate(0, rotationRange, 0);
                }
                if (gas1 > 0) { // gas with right trigger
                    carRB.AddForce(transform.forward * carSpeed * gas1);
                }
                if (brake1 > 0) { // brake with left trigger
                    carRB.AddForce(-transform.forward * brakes * brake1);
                }
            }

            //Buttons that control car 2.
            if (car2) {
                if (Input.GetKey(KeyCode.UpArrow)) {
                    carRB.AddForce(transform.forward * carSpeed);
                }
                if (Input.GetKey(KeyCode.LeftArrow) || LeftHorizontalValue2 < -0.5f) {
                    gameObject.transform.Rotate(0, -rotationRange, 0);
                }
                if (Input.GetKey(KeyCode.DownArrow)) {
                    carRB.AddForce(-transform.forward * carSpeed);
                }
                if (Input.GetKey(KeyCode.RightArrow) || LeftHorizontalValue2 > 0.5f) {
                    gameObject.transform.Rotate(0, rotationRange, 0);
                }
                if (gas2 > 0)
                { // gas with right trigger
                    carRB.AddForce(transform.forward * carSpeed * gas2);
                }
                if (brake2 > 0)
                { // brake with left trigger
                    carRB.AddForce(-transform.forward * brakes * brake2);
                }
            }
        }

        if (track2) {
            if (car3) {
                if (Input.GetKey(KeyCode.W)) { //forward keyboard
                    carRB.AddForce(transform.forward * carSpeed);
                }
                if (Input.GetKey(KeyCode.A) || LeftHorizontalValue < -0.5f) { //left
                    gameObject.transform.Rotate(0, -rotationRange, 0);
                }
                if (Input.GetKey(KeyCode.S)) { //backward keyboard
                    carRB.AddForce(-transform.forward * carSpeed);
                }
                if (Input.GetKey(KeyCode.D) || LeftHorizontalValue > 0.5f) { //right
                    gameObject.transform.Rotate(0, rotationRange, 0);
                }
                if (gas1 > 0) { // gas with right trigger
                    carRB.AddForce(transform.forward * carSpeed * gas1);
                }
                if (brake1 > 0) { // brake with left trigger
                    carRB.AddForce(-transform.forward * brakes * brake1);
                }
            }

            //Buttons that control car 2.
            if (car4) {
                if (Input.GetKey(KeyCode.UpArrow)) {
                    carRB.AddForce(transform.forward * carSpeed);
                }
                if (Input.GetKey(KeyCode.LeftArrow) || LeftHorizontalValue2 < -0.5f) {
                    gameObject.transform.Rotate(0, -rotationRange, 0);
                }
                if (Input.GetKey(KeyCode.DownArrow)) {
                    carRB.AddForce(-transform.forward * carSpeed);
                }
                if (Input.GetKey(KeyCode.RightArrow) || LeftHorizontalValue2 > 0.5f) {
                    gameObject.transform.Rotate(0, rotationRange, 0);
                }
                if (gas2 > 0) { // gas with right trigger
                    carRB.AddForce(transform.forward * carSpeed * gas2);
                }
                if (brake2 > 0) { // brake with left trigger
                    carRB.AddForce(-transform.forward * brakes * brake2);
                }
            }
        }
    }
}

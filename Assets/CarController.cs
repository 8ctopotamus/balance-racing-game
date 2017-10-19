using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour {

	public float speed = 1500f;
	public float rotationSpeed = 15f;

	public WheelJoint2D frontWheel;
	public WheelJoint2D backWheel;
	public Rigidbody2D rb;

	private float movement = 0f;
	private float rotation = 0f;

	void Update () {
		movement = -Input.GetAxisRaw("Vertical") * speed;
		rotation = Input.GetAxisRaw("Horizontal");
	}

	void FixedUpdate () {
		if (movement == 0f) {
			frontWheel.useMotor = false;
			backWheel.useMotor = false;
		} else {
			frontWheel.useMotor = true;
			backWheel.useMotor = true;

			JointMotor2D motor = new JointMotor2D { motorSpeed = movement, maxMotorTorque = backWheel.motor.maxMotorTorque };

			frontWheel.motor = motor;
			backWheel.motor = motor;
		}

		rb.AddTorque(-rotation * rotationSpeed * Time.fixedDeltaTime);
	}

}

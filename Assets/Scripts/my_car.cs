using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class my_car : MonoBehaviour
{
	private Rigidbody rigidCar;
	public int MovSpeed;
	public int RotSpeed;

	// Start is called before the first frame update
	void Start()
	{
		rigidCar = GetComponent<Rigidbody>(); // reference the object like a rigid body
	}

	// Update is called once per frame
	void Update()
	{
		/* movimentation keys */
		if (Input.GetKey(KeyCode.W)) // move foward
		{
			rigidCar.AddForce(transform.forward * MovSpeed * Time.deltaTime, ForceMode.Impulse);
		}
		if (Input.GetKey(KeyCode.S)) // move back
		{
			rigidCar.AddForce(transform.forward * -1*MovSpeed * Time.deltaTime, ForceMode.Impulse);
		}
		if (Input.GetKey(KeyCode.A)) // turn left
		{
			transform.Rotate(0, -1*RotSpeed, 0);
		}
		if (Input.GetKey(KeyCode.D)) // turn right
		{
			transform.Rotate(0, RotSpeed, 0);
		}
	}
}

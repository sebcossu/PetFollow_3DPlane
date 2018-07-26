using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedFollows : MonoBehaviour
{
    [SerializeField] Transform goal;
    [SerializeField] float accuracy = 1.0f;
    [SerializeField] float speed = 8.0f;
    [SerializeField] float rotSpeed = 100.0f;

	void LateUpdate ()
	{
		Vector3 lookAtGoal = new Vector3(goal.position.x, this.transform.position.y, goal.position.z);
		Vector3 direction  = lookAtGoal - this.transform.position;

		this.transform.rotation = Quaternion.Slerp(this.transform.rotation, Quaternion.LookRotation(direction), Time.deltaTime * rotSpeed);

		if(Vector3.Distance(transform.position, lookAtGoal) > accuracy)
		{
	        this.transform.Translate(0, 0, speed * Time.deltaTime);
		}
	}
}

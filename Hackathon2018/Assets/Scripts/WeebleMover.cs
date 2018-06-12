using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeebleMover : MonoBehaviour
{
	private Vector3 _direction;

	private void OnTriggerEnter(Collider other)
	{
		_direction = Vector3.zero;
	}

	// Update is called once per frame
	void Update ()
	{		
		var dt = Time.deltaTime;
		var velocity = 1.0f;
	
		transform.position = transform.position + (dt * velocity * _direction);
	}

	public void Init(Spawner.Direction d)
	{
		if (d == Spawner.Direction.back)
		{
			_direction = Vector3.back;
		}
		else
		{
			_direction = Vector3.forward;
		}
	}
}

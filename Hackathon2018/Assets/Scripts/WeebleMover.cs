using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeebleMover : MonoBehaviour
{
	private Vector3 _direction;
	private Spawner.Team _team;
	private Vector3 _startPosition; 
	// Use this for initialization
	void Start ()
	{
		_startPosition = transform.position;
		
	}

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

	public void Init(Spawner.Team t, Spawner.Direction d)
	{
		if (d == Spawner.Direction.back)
		{
			_direction = Vector3.back;
		}
		else
		{
			_direction = Vector3.forward;
		}

		_team = t;
	}
}

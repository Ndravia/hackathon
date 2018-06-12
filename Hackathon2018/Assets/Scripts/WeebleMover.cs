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
	
	// Update is called once per frame
	void Update ()
	{
		Vector3 traveled = transform.position - _startPosition;
		float Distance = traveled.magnitude;
		
		if (Distance < 10)
		{
			
			var dt = Time.deltaTime;
			var velocity = 1.0f;
		
			transform.position = transform.position + (dt * velocity * _direction);

		}
		else
		{
			
		}
	}

	public void Init(Spawner.Team team, Spawner.Direction direction)
	{
		if (direction == Spawner.Direction.back)
		{
			_direction = Vector3.back;
		}
		else
		{
			_direction = Vector3.forward;
		}

		_team = team;
	}
}

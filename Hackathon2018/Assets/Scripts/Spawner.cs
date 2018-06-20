using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

public class Spawner : MonoBehaviour
{
	public Team WeebleTeam;
	public Direction WeebleDirection;
	public List<GameObject> Weebles = new List<GameObject>();
	public float SpawnTimer = 2f;

	private int Index = 0;
	private float _timer = 0;
	
	// Use this for initialization

	private void InstantiateWeeble(GameObject prefab, Transform location)
	{
		GameObject weeble = Instantiate(prefab);
		weeble.transform.position = location.position;
		WeebleMover mover = weeble.GetComponent<WeebleMover>();
		mover.Init(WeebleDirection, WeebleTeam);
	}

	private void Update()
	{
		float dt = Time.deltaTime;
		if (_timer >= SpawnTimer)
		{
			_timer = 0;
		   SpawnWeebles();
		}
		else
		{
			_timer = _timer + dt;
		}
	}

	public void SpawnWeebles()
	{
		if (Index < Weebles.Count)
		{
			GameObject Weeble = Weebles[Index];
			Index++;
			InstantiateWeeble(Weeble, transform);
		}
	}
}


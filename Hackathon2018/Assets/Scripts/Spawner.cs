using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
	public enum Direction
	{
		back,
		forward,
	}

	public Direction WeebleDirection;
	public GameObject MeleeWeeblePrefab;
	public GameObject HealerWeeblePrefab;
	public GameObject TankWeeblePrefab;
	public GameObject RangedWeeblePrefab;
	public Transform Location1;
	public Transform Location2;
	public Transform Location3;
	public Transform Location4;
	public Transform Location5;
	
	// Use this for initialization
	void Start ()
	{
		InstantiateWeeble(MeleeWeeblePrefab, Location1);
		InstantiateWeeble(HealerWeeblePrefab, Location2);
		InstantiateWeeble(TankWeeblePrefab, Location3);
		InstantiateWeeble(MeleeWeeblePrefab, Location4);
		InstantiateWeeble(RangedWeeblePrefab, Location5);
	}

	private void InstantiateWeeble(GameObject prefab, Transform location)
	{
		GameObject weeble = Instantiate(prefab);
		weeble.transform.position = location.position;
		WeebleMover mover = weeble.GetComponent<WeebleMover>();
		mover.Init(WeebleDirection);
	}
}

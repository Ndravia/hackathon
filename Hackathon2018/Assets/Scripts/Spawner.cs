using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
	public enum Team
	{
		TeamA, 
		TeamB,
	}

	public enum Direction
	{
		back,
		forward,
	}

	public Team TeamWeeble;
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
		GameObject weeble1 = Instantiate(MeleeWeeblePrefab);
		weeble1.transform.position = Location1.position;
		WeebleMover mover1 = weeble1.GetComponent<WeebleMover>();
		mover1.Init(TeamWeeble, WeebleDirection);

		GameObject weeble2 = Instantiate(HealerWeeblePrefab);
		weeble2.transform.position = Location2.position;
		WeebleMover mover2 = weeble2.GetComponent<WeebleMover>();
		mover2.Init(TeamWeeble, WeebleDirection);
		
		GameObject weeble3 = Instantiate(TankWeeblePrefab);
		weeble3.transform.position = Location3.position;
		WeebleMover mover3 = weeble3.GetComponent<WeebleMover>();
		mover3.Init(TeamWeeble,WeebleDirection);
		
		GameObject weeble4 = Instantiate(MeleeWeeblePrefab);
		weeble4.transform.position = Location4.position;
		WeebleMover mover4 = weeble4.GetComponent<WeebleMover>();
		mover4.Init(TeamWeeble, WeebleDirection);
		
		GameObject weeble5 = Instantiate(RangedWeeblePrefab);
		weeble5.transform.position = Location5.position;
		WeebleMover mover5 = weeble5.GetComponent<WeebleMover>();
		mover5.Init(TeamWeeble, WeebleDirection);
	}

	private void InstantiateWeeble(GameObject prefab, Transform location)
	{
		GameObject weeble = Instantiate(prefab);
		weeble.transform.position = location.position;
		WeebleMover mover = weeble.GetComponent<WeebleMover>();
		mover.Init(TeamWeeble, WeebleDirection);

	}
	// Update is called once per frame
	void Update () {
		
	}
}

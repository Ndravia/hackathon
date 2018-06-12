using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
	public GameObject MeleeWeeblePrefab;
	public GameObject HealerWeeblePrefab;
	public GameObject TankWeeblePrefab;
	public GameObject RangedWeeblePrefab;
	public Transform Location1;
	public Transform Location2;
	public Transform Location3;
	public Transform Location4;
	public Transform Location5;
	public Transform Location6;
	public Transform Location7;
	public Transform Location8;
	public Transform Location9;
	public Transform Location10;
	
	
	// Use this for initialization
	void Start ()
	{
		GameObject weeble1 = Instantiate(MeleeWeeblePrefab);
		weeble1.transform.position = Location1.position;

		GameObject weeble2 = Instantiate(HealerWeeblePrefab);
		weeble2.transform.position = Location2.position;
		
		GameObject weeble3 = Instantiate(TankWeeblePrefab);
		weeble3.transform.position = Location3.position;
		
		GameObject weeble4 = Instantiate(MeleeWeeblePrefab);
		weeble4.transform.position = Location4.position;
		
		GameObject weeble5 = Instantiate(RangedWeeblePrefab);
		weeble5.transform.position = Location5.position;

		GameObject weeble6 = Instantiate(MeleeWeeblePrefab);
		weeble6.transform.position = Location6.position;

		GameObject weeble7 = Instantiate(HealerWeeblePrefab);
		weeble7.transform.position = Location7.position;

		GameObject weeble8 = Instantiate(TankWeeblePrefab);
		weeble8.transform.position = Location8.position;

		GameObject weeble9 = Instantiate(MeleeWeeblePrefab);
		weeble9.transform.position = Location9.position;

		GameObject weeble10 = Instantiate(RangedWeeblePrefab);
		weeble10.transform.position = Location10.position;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

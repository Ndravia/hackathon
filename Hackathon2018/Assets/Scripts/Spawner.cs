using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
	public GameObject WeeblePrefab;
	public Transform Location1;
	public Transform Location2;
	public Transform Location3;
	public Transform Location4;
	public Transform Location5;
	
	// Use this for initialization
	void Start ()
	{
		GameObject weeble1 = Instantiate(WeeblePrefab);
		weeble1.transform.position = Location1.position;

		GameObject weeble2 = Instantiate(WeeblePrefab);
		weeble2.transform.position = Location2.position;
		
		GameObject weeble3 = Instantiate(WeeblePrefab);
		weeble3.transform.position = Location3.position;
		
		GameObject weeble4 = Instantiate(WeeblePrefab);
		weeble4.transform.position = Location4.position;
		
		GameObject weeble5 = Instantiate(WeeblePrefab);
		weeble5.transform.position = Location5.position;
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

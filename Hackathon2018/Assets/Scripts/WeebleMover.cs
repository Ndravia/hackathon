using UnityEngine;

public class WeebleMover : MonoBehaviour
{
	public float velocity = 1.0f;
	public int Health = 100;
	public int Damage = 1;
	public float CoolDown = 1.5f;
	public bool IsDead = false;
		
	private WeebleMover _enemyWeeble;
	private Vector3 _direction;
	private float _timer;

	private void OnTriggerEnter(Collider other)
	{
		_enemyWeeble = other.transform.parent.gameObject.GetComponent<WeebleMover>();
	}	

	// Update is called once per frame
	void Update ()
	{
		var dt = Time.deltaTime;
	
		if (_enemyWeeble != null)
		{
			//do damage
			if (_timer > CoolDown)
			{
				_enemyWeeble.TakeDamage(Damage);
				_timer = 0;
				if (_enemyWeeble.IsDead)
				{
					_enemyWeeble = null;
				}
			}
			else
			{
				_timer = _timer + dt;
			}
		}
		else
		{
			transform.position = transform.position + (dt * velocity * _direction);
		}

		if (IsDead)
		{
			Destroy(gameObject);
		}
	}

	public void TakeDamage(int damagetaken)
	{
		Health = Health - damagetaken;
		if (Health <= 0)
		{
			IsDead = true;
			Debug.Log("A Weeble Has Died!");
		}
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

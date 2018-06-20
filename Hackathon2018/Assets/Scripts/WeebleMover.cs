using JetBrains.Annotations;
using UnityEngine;

public class WeebleMover : MonoBehaviour
{
	public float velocity = 1.0f;
	public int Health = 100;
	public int Damage = 1;
	public float CoolDown = 1.5f;
	public bool IsDead = false;
	public Color FullHealth = Color.green;
	public Color MediumHealth = Color.yellow;
	public Color LowHealth = Color.red;
	public Renderer ModelRenderer;

	public Team WeebleTeam;
	private int MaxHealth;
	private WeebleMover _enemyWeeble;
	private Vector3 _direction;
	private float _timer;

	private void Start()
	{
		MaxHealth = Health;
		SetColor(FullHealth);
	}
	private void OnTriggerEnter(Collider other)
	{
		WeebleMover Weeble = other.gameObject.GetComponent<WeebleMover>();
		if (Weeble != null && Weeble.WeebleTeam != WeebleTeam)
		{
			_enemyWeeble = Weeble;
		}
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

		Color NewColor = GetHealthColor();
		SetColor(NewColor);
	}
	
	public void Init(Direction d, Team t)
	{
		WeebleTeam = t;
		if (d == Direction.back)
		{
			_direction = Vector3.back;
		}
		else
		{
			_direction = Vector3.forward;
		}
	}

	public void SetColor(Color color)
	{
		ModelRenderer.material.color = color;
	}

	public Color GetHealthColor()
	{
		float FullHealthThreshold = 1f;
		float MediumHealthThreshold = 0.5f;
		float LowHealthThreshold = 0.25f;
		float Percent = (float)Health / (float)MaxHealth;
		Color NewColor;
		
		if (Percent > MediumHealthThreshold)
		{
			float MaxPercent = (Percent - MediumHealthThreshold) / (FullHealthThreshold - MediumHealthThreshold);
			float MidPercent = (1 - MaxPercent);
		
			NewColor = new Color((FullHealth.r * MaxPercent) + (MediumHealth.r * MidPercent), 
				(FullHealth.g * MaxPercent) + (MediumHealth.g * MidPercent),
				(FullHealth.b * MaxPercent) + (MediumHealth.b * MidPercent));
		}
		else
		{
			float MidPercent = (Percent - LowHealthThreshold) / (MediumHealthThreshold - LowHealthThreshold);
			float LowPercent = (1 - MidPercent);
		
			NewColor = new Color((MediumHealth.r * MidPercent) + (LowHealth.r * LowPercent), 
				(MediumHealth.g * MidPercent) + (LowHealth.g * LowPercent),
				(MediumHealth.b * MidPercent) + (LowHealth.b * LowPercent));
		}
		//return NewColor;
		return Color.Lerp(Color.red, Color.green, Percent);
	}
}

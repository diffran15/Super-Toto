using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
	PlayerMovement MoveComponent;
	// Start is called before the first frame update
	void Start()
	{
		MoveComponent = GameObject.Find("Player").GetComponent<PlayerMovement>();
	}

	// Update is called once per frame
	void Update()
	{

	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.transform.tag == "Player")
		{
			MoveComponent.health++;
			Destroy(gameObject);
		}
	}
}
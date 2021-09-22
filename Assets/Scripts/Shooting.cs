using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
	public Transform FirePoint;
	public GameObject BulletPrefab;
	public int damage = 40;
	public float bulletForce = 20f;
	public bool ShootButton ;

	// Update is called once per frame
	void Update()
	{
		if (Input.GetKeyDown(KeyCode.Space))
		{
			Shoot();
		}
	}

	void Shoot()
	{
		Instantiate(BulletPrefab, FirePoint.position, FirePoint.rotation);      //memunculkan Bullet saat Ditembakan
		//Rigidbody2D rb = Bullet.GetComponent<Rigidbody2D>();        //akses component rigidbody2D
		//rb.AddForce(FirePoint.up * bulletForce, ForceMode2D.Impulse);

	}

	public void HoldShootButton()
	{
		ShootButton = true;
	}
	public void LepasShootButton()
	{
		ShootButton = false;
	}

}

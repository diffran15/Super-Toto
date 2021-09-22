using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
	//membuat variabel yang menjadi target untuk diikuti oleh Camera
	[SerializeField]
	private Transform target;


	private void Update()
	{
		//this.transform.position itu maksudnya adalah Camera terus setiap ada update maka posisi Camera persisnya
		//pada sumbu x akan bertambah atau berkurang sesuai dengan sumbu x yang ada pada Player
		this.transform.position = new Vector3(target.transform.position.x, target.transform.position.y, target.transform.position.z - 10f);
	}
	/*public float xMargin = 0.5f;
	public float yMargin = 0.5f;
	public float xSmooth = 4f;
	public float ySmooth = 4f;
	public Vector2 maxXandY;
	public Vector2 minXandY;

	private Transform player;

	void Awake()
	{
		player = GameObject.FindGameObjectWithTag("Player").transform;
	}

	bool CheckXMargin()
	{
		return Mathf.Abs(transform.position.x - player.position.x) > xMargin;
	}

	bool CheckYMargin()
	{
		return Mathf.Abs(transform.position.y - player.position.y) > yMargin;
	}

	void FixedUpdate()
	{
		TrackPlayer();
	}

	void TrackPlayer()
	{
		float TargetX = transform.position.x;
		float TargetY = transform.position.y;

		if (CheckXMargin())
			TargetX = Mathf.Lerp(transform.position.x, player.position.x, xSmooth * Time.deltaTime);
		if (CheckYMargin())
			TargetX = Mathf.Lerp(transform.position.y, player.position.y, ySmooth * Time.deltaTime);

		TargetX = Mathf.Clamp(TargetX, minXandY.x, maxXandY.x);
		TargetY = Mathf.Clamp(TargetY, minXandY.y, maxXandY.y);

		transform.position = new Vector3(TargetX, TargetY, transform.position.z);
	}*/
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
	Text healthinfo, coininfo;

	public int speed, powerjump;
	private bool flip = true ;
	public int move;

	public int health;
	public int coin;

	Rigidbody2D jump;

	public bool ground;
	public LayerMask TargetLayer;
	public Transform groundDetection;
	public float reach;

	Animator anim;

	Vector2 start;
	public bool back;

	public bool LeftButton;
	public bool RightButton;
	public bool JumpButton;
	public bool ShootButton;

	public GameObject Win, Lose;


    // Start is called before the first frame update
    void Start()
    {
		healthinfo = GameObject.Find("UIhealth").GetComponent<Text>();
		coininfo = GameObject.Find("UIcoin").GetComponent<Text>();
		jump = GetComponent<Rigidbody2D>();
		anim = GetComponent<Animator>();
		start = transform.position;
    }

	// Update is called once per frame
	void Update()
	{
		healthinfo.text = "Health : " + health.ToString();
		coininfo.text = "Coin : " + coin.ToString();

		if (back == true)
		{
			transform.position = start;
			back = false;
		}
		if (health <= 0)
		{
			//anim.SetTrigger("isDead");
			Destroy(gameObject);
			Lose.SetActive(true);
		}

		else if (coin >=15)
		{
			Win.SetActive(true);
		}

		if (ground == false)
		{
			anim.SetBool("isJump", true);
		}
		else
		{
			anim.SetBool("isJump", false);
		}

		ground = Physics2D.OverlapCircle(groundDetection.position, reach, TargetLayer);

		

		if (Input.GetKey(KeyCode.D) || (RightButton == true))
		{
			anim.SetBool("isRun", true);
			transform.Translate(Vector2.right * speed * Time.deltaTime);
			move = 1;
		}
		else if (Input.GetKey(KeyCode.A) || (LeftButton == true))
		{
			anim.SetBool("isRun", true);
			transform.Translate(Vector2.right * speed * Time.deltaTime);
			move = -1;
		}
		else
		{
			anim.SetBool("isRun", false);
		}

		if (ground == true && (Input.GetKey(KeyCode.W) || (JumpButton == true)))
		{
			jump.AddForce(new Vector2(0, powerjump));
		}

		if (move > 0 && !flip)
		{
			FlipBody();
		}
		else if (move < 0 && flip)
		{
			FlipBody();
		}
	}
	private void FlipBody()
	{
		
		flip = !flip;
		/*Vector3 character = transform.localScale;
		character.x *= -1;
		transform.localScale = character;*/
		transform.Rotate(0f, 180f, 0f);
	}

	public void HoldLeftButton()
	{
		LeftButton = true;
	}
	public void LepasLeftButton()
	{
		LeftButton = false;
	}
	public void HoldRightButton()
	{
		RightButton = true;
	}
	public void LepasRightButton()
	{
		RightButton = false;
	}
	public void HoldJumpButton()
	{
		JumpButton = true;
	}
	public void LepasJumpButton()
	{
		JumpButton = false;
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

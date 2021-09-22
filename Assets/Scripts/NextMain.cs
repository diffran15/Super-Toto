using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextMain : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

	public void next(int nextMenu)
	{
		Application.LoadLevel(nextMenu);
	}
}

using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MenuController: MonoBehaviour {
	// Use this for initialization
	void Start () {
	
	}
	// Update is called once per frame
	void Update () {
		if(Application.loadedLevelName.Equals("Menu"))
		{
        	if (this.GetComponent<RawImage>().color.a >= 0.99f)
        	{
         		Application.LoadLevel("Game");
        	}
		}
		else if(Application.loadedLevelName.Equals("Game"))
		{
			if (this.GetComponent<RawImage>().color.a >= 0.99f)
			{
				Application.LoadLevel("GameOver");
			}
		}
	}
}

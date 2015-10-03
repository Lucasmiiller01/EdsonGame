using UnityEngine;using UnityEngine.UI;
using System.Collections;

public class GameOver : MonoBehaviour {

	public Text text;
	public Text text2;
	// Use this for initialization
	void Start () {
		if(FoodBehaviour.score > PlayerPrefs.GetInt("BestScore") || PlayerPrefs.GetInt("BestScore").Equals(null))
		{
			PlayerPrefs.SetInt("BestScore",FoodBehaviour.score);
		}
		text.text = "Score:  " + FoodBehaviour.score.ToString();
		text2.text = "Best Score:  " + PlayerPrefs.GetInt ("BestScore").ToString();
	}
	
	// Update is called once per frame
	void Update () {

		
	
	}

	void OnMouseDown(){
		Application.LoadLevel("Menu");
	}
}

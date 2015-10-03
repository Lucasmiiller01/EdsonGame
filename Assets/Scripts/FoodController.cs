using UnityEngine;

using System.Collections;

public class FoodController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
		rigidbody2D.AddForce (new Vector2 (0, FoodBehaviour.score * -1.2f - 100));
	
	}
	
	// Update is called once per frame
	void Update () {
	}
	void OnMouseDown(){
		if (gameObject.tag.Equals ("Bad")) {
			Destroy(gameObject);
		}
		else if(gameObject.tag.Equals ("Good")){
			FoodBehaviour.vida -= 1;
			Destroy(gameObject);
		}
	}
}

using UnityEngine;
using System.Collections;

public class Destroyer : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnCollisionEnter2D(Collision2D col){
		if (col.gameObject.tag.Equals ("Bad")) {
			Destroy(col.gameObject);
			FoodBehaviour.vida -= 1;
		}
		else if(col.gameObject.tag.Equals ("Good")){
			Destroy(col.gameObject);
		}
	}
}

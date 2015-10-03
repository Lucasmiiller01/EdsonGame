using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class FoodBehaviour : MonoBehaviour {
    public Canvas Mycanvas;
    public GameObject[] Foods;
	public static int score;
	public static int vida; 
	public Text texto;
	public GameObject[] vidaSprite = new GameObject[3];
	public GameObject fade;
	// Use this for initialization
	void Start () {
		Mycanvas.worldCamera = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
		StartCoroutine(Spaw());
		StartCoroutine(Score());
		vida = 3;
		score = 0;

	}
	
	// Update is called once per frame
	void Update () {
		texto.text = "Score:  " + score.ToString ();
		if (vida <= 2) 
		{
			vidaSprite[2].SetActive(false);
		}
		if (vida <= 1) 
		{
			vidaSprite[1].SetActive(false);
		}
		if (vida < 1) {
			vidaSprite[0].SetActive(false);
			fade.SetActive(true);
		}


	}
		 
    IEnumerator Spaw()
    {
        int comida = Random.Range(0, Foods.Length);
        Instantiate(Foods[comida], new Vector2(Random.Range(-2, 2), 6), Quaternion.identity);
        yield return new WaitForSeconds(Mathf.Pow(1/2,score/5) + 1);
        StartCoroutine(Spaw());
	}
	IEnumerator Score()
	{
		yield return new WaitForSeconds(1);
		if (vida > 0)score += 5;
		StartCoroutine(Score());
	}
}

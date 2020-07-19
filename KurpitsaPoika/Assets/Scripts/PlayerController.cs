using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	// pelihahmon maksiminopeus
	public float maxNopeus = 5f;

	// Pelaajan oletussuunta on eteenpäin
	bool suuntaOikea = true;

	// Pelihahmo fusiikka ominaisuudet
	Rigidbody2D rb2d;

	// Animointia varten 
	Animator anim;

	// Use this for initialization
	void Start () {
		// Viitaukset komponetteihin
		anim = GetComponent<Animator>();
		rb2d = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void FixedUpdate(){

		//Liikutetaan pelihahmoa nuolinäppäimellä vaakatasossa
		//move saa arvat -1...1
		float move = Input.GetAxis ("Horizontal");
		Debug.Log("move:" + move);
		// Debug.Log ("Move:" + move);

		// Jos move > 0,1, niin animoidaan juoksu
		anim.SetFloat("Nopeus" , Mathf.Abs(move));

		// Pelihahmo liikkuu eteenpäin (x-akselia) nopeudella move*maxNopeus, yövakio
		rb2d.velocity = new Vector2(move * maxNopeus, rb2d.velocity.y);


		// Tutkitaan pelihahmon suunta ja käännetään se
		if(move > 0 && !suuntaOikea ){
			Flip ();
		}else if(move < 0 && suuntaOikea){
			Flip ();
		}

	}


	void Flip (){

		// Vaihdetaan pelaajan suunta
		suuntaOikea = !suuntaOikea;
		Vector3 skaala = transform.localScale;
		skaala.x *= -1;
		transform.localScale = skaala;

	}

}

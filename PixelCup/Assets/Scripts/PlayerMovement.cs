using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	// Pelihahmon nopeus
	public float moveSpeed = 0.5f;
	// Määritellään tarvittavat muuttujat
	Rigidbody2D rbody;
	Animator anim;

	// Use this for initialization
	void Start () {

		// Luodaan yhteys komponentteihin
		rbody = GetComponent<Rigidbody2D>();
		anim = GetComponent<Animator> ();
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {

		// Liike talletetaan vektoriin
		Vector2 movement_vector = new Vector2(Input.GetAxisRaw("Horizontal"), 
			Input.GetAxisRaw("Vertical"));

		//Debug.Log ("movement_vector: " + movement_vector);

		// Tarkistetaan liikkuuko pelihahmo
		if(movement_vector != Vector2.zero){
			// Pelihahmo liikkuu
			anim.SetBool("isWalking", true);
			anim.SetFloat("input_x", movement_vector.x);
			anim.SetFloat ("input_y", movement_vector.y);
		}else{
			anim.SetBool ("isWalking", false);
		}

		// Liikutetaan mummua
		rbody.MovePosition(rbody.position + movement_vector * Time.deltaTime * moveSpeed);
	
	}
}

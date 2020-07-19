using UnityEngine;
using System.Collections;

public class Generate : MonoBehaviour {

	public GameObject rocks; 

	// Use this for initialization
	void Start () {
	
		InvokeRepeating ("CreateObstacle",1f, 1.5f);

	}

	void OnGUI(){
		GUI.color = Color.black;
		GUILayout.Label (" Pisteet: " + score.Tostring ());
	}


	void CreateObstacle(){

		Instantiate (rocks);
			score++;

	}

}

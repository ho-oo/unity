using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {


	//Seurattava kohde
	public Transform target;

	//Nopeus jolla kamera seuraa
	public float m_speed = 0.01f;

	//Yhteys kameraan
	Camera camera;

	// Use this for initialization
	void Start () {

		// Referenssi kameraan
		camera = GetComponent<Camera>();

	}

	// Update is called once per frame
	void Update () {

		// Kameran näyttämä alue
		camera.orthographicSize = (Screen.height / 100) / 1f;

		//Siiretään kamera sinne missä seurattava kohde on
		transform.position = Vector3.Lerp(transform.position, target.position, m_speed) + new Vector3(0f,0f,-10f);
	}
}
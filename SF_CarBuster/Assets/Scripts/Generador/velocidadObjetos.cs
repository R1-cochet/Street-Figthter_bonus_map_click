using UnityEngine;
using System.Collections;

public class velocidadObjetos : MonoBehaviour {

	public float velocidad = 8;
	// Use this for initialization
	void Start () {
		this.gameObject.GetComponent<Rigidbody2D> ().velocity = new Vector2 (GetComponent<Rigidbody2D> ().velocity.x,-velocidad);	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

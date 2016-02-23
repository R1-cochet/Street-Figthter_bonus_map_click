using UnityEngine;
using System.Collections;

public class Acierto : MonoBehaviour {

	Collider2D other;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.RightArrow)) {
			print ("flecha derecha a sido precionada");
			if (other!=null && other.tag == "Patada") {
				print ("Acierto");
				other = null;
			} else {
				print ("No Acierto");
			}
		}

		if (Input.GetKeyDown (KeyCode.LeftArrow)) {
			print ("flecha Izquierda a sido precionada");
			if (other!=null && other.tag == "Puño") {
				print ("Acierto");
				other = null;
			} else {
				print ("No Acierto");
			}
		}	
	}

	void OnTriggerEnter2D(Collider2D other1){
		other = other1;
	}
}

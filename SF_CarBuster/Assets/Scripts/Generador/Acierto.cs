using UnityEngine;
using System.Collections;

public class Acierto : MonoBehaviour {

	Collider2D other;
	public GameObject ken;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		ken.GetComponent<Animator> ().SetBool ("Kick",false);
		ken.GetComponent<Animator> ().SetBool ("Punch",false);
		ken.GetComponent<Animator> ().SetBool ("Hit",false);



		if (Input.GetKeyDown (KeyCode.RightArrow)) {
			print ("flecha derecha a sido precionada");
			if (other!=null && other.tag == "Patada") {
				print ("Acierto");
				ken.GetComponent<Animator> ().SetBool ("Kick",true);
				other = null;
			} else {
				print ("No Acierto");
				ken.GetComponent<Animator> ().SetBool ("Hit",true);
			}
		}

		if (Input.GetKeyDown (KeyCode.LeftArrow)) {
			print ("flecha Izquierda a sido precionada");
			if (other!=null && other.tag == "Puño") {
				print ("Acierto");
				ken.GetComponent<Animator> ().SetBool ("Punch",true);
				other = null;
			} else {
				print ("No Acierto");
				ken.GetComponent<Animator> ().SetBool ("Hit",true);
			}
		}	
	}

	void OnTriggerEnter2D(Collider2D other1){
		other = other1;
	}
}

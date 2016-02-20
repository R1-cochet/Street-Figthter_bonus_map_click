using UnityEngine;
using System.Collections;

public class Controls : MonoBehaviour {

	
	void Update () {
	if (Input.GetKeyDown (KeyCode.RightArrow))
			print ("flecha derecha a sido precionada");

	if(Input.GetKeyDown(KeyCode.UpArrow))
			print("flecha arriba a sido precionada");

	if(Input.GetKeyDown(KeyCode.DownArrow))
			print("flecha abajo a sido precionada");

    if(Input.GetKeyDown(KeyCode.LeftArrow))
			print("flecha Izquierda a sido precionada");

	}
}
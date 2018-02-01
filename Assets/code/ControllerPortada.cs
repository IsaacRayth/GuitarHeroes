using UnityEngine;
using System.Collections;

public class ControllerPortada : MonoBehaviour {
	void Update () {
		if(Input.GetKeyDown(KeyCode.Escape)){
			Debug.Log("Salimos del juego cual juego??");
			Application.Quit();
			//Application.LoadLevel("Portada");
		}
		if(Input.GetKeyDown(KeyCode.F1)){
			Application.LoadLevel("2");
		}
		if(Input.GetKeyDown(KeyCode.F2)){
			Application.LoadLevel("1");
		}
		if(Input.GetKeyDown(KeyCode.F3)){
			Application.LoadLevel("3");
		}
	}
}

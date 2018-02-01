using UnityEngine;
using System.Collections;

public class inicia : MonoBehaviour {
	public bool inicio = false; 
	void OnTriggerEnter(Collider collision){
		Debug.Log (collision.gameObject.name);
		if(collision.gameObject.name!="Cube 5"){
			inicio = true;
		}
	}
}

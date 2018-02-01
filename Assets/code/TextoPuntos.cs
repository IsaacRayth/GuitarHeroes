using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TextoPuntos : MonoBehaviour {
	public string nombre;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		GetComponent<Text>().text = PlayerPrefs.GetInt (nombre) + "";
	}
}

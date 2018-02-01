using UnityEngine;
using System.Collections;

public class AccionP : MonoBehaviour {
	public Material A;
	public Material B;
	private Renderer colorCubo;
	public KeyCode key;

	// Use this for initialization
	void Start () {
		colorCubo = GetComponent<Renderer>();
		colorCubo.material = A;
	}
	// Update is called once per frame
	void Update () {
		 

			if(Input.GetKeyDown(key)){
				colorCubo = GetComponent<Renderer>();
				colorCubo.material = B;
			}
			if(Input.GetKeyUp(key)){
				colorCubo = GetComponent<Renderer>();
				colorCubo.material = A;
			}
	}
}
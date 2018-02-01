using UnityEngine;
using System.Collections;

public class hee : MonoBehaviour {
	float x;
	float y;
	float z;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		x = 0 * Time.deltaTime;
		y = 0 * Time.deltaTime;
		z = 9f * Time.deltaTime;
		transform.localScale -= new Vector3(x,y,z);
	}
}

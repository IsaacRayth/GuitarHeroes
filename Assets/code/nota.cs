using UnityEngine;
using System.Collections;

public class nota : MonoBehaviour {
	public float velocidad = 9f;
	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {
		float posZ = transform.position.z +(-1 * velocidad * Time.deltaTime);
		transform.position = new Vector3 (transform.position.x,transform.position.y,posZ);
	}
}

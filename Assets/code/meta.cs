using UnityEngine;
using System.Collections;

public class meta : MonoBehaviour {
	float Rm;
	GameObject MetaRock;
	void Start () {
		MetaRock = transform.Find("MetaRock").gameObject;
	}

	void Update () {

		Rm = PlayerPrefs.GetInt ("Meta");
		MetaRock.transform.localPosition = new Vector3 (0, 0, (Rm - 25)/25);
	}
}

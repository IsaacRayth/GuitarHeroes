using UnityEngine;
using System.Collections;

public class play : MonoBehaviour {
	public inicia primera;
	public AudioSource Loint;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(primera!=null){
			if(primera.inicio==true){
				Loint.Play();
				primera=null;
			}
		}
	}

}

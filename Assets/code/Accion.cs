using UnityEngine;
using System.Collections;

public class Accion : MonoBehaviour {
	public Material A;
	public Material B;
	private Renderer colorCubo;
	public KeyCode key;
	private bool active = false;
	GameObject note;
	public controlador gn;

	public bool modoCreacion;
	public GameObject n;
	// Use this for initialization
	void Start () {
		PlayerPrefs.SetInt ("Score",0);
		PlayerPrefs.SetInt ("Mult",1);
		PlayerPrefs.SetInt ("Streak",0);
		colorCubo = GetComponent<Renderer>();
		colorCubo.material = A;
	}
	// Update is called once per frame
	void Update () {
		 
		if (modoCreacion){
			if(Input.GetKeyDown(key)){
				Instantiate(n,transform.position,Quaternion.identity);
			}
		}else{
			if(Input.GetKeyDown(key)){
				colorCubo = GetComponent<Renderer>();
				colorCubo.material = B;
			}
			if(Input.GetKeyDown(key)&&active){
				Destroy(note);
				gn.GetComponent<controlador>().AddStreak();
				AgregarPuntos();
				active=false;
			}else if(Input.GetKeyDown(key)&&!active){
				gn.GetComponent<controlador>().ResetStreak();
			}
			if(Input.GetKeyUp(key)){
				colorCubo = GetComponent<Renderer>();
				colorCubo.material = A;
			}
		}
	}
	void OnTriggerEnter(Collider collision){
		if (collision.gameObject.tag == "Win") {
			gn.GetComponent<controlador>().win();
		}
		if(collision.gameObject.tag=="note"){
			note=collision.gameObject;
			active = true;
		}
	}
	
	void OnTriggerExit(Collider collision){
		active = false;
		gn.GetComponent<controlador>().ResetStreak();
	}

	void AgregarPuntos(){
		PlayerPrefs.SetInt ("Score",PlayerPrefs.GetInt("Score")+gn.GetComponent<controlador>().GetScore());
	}
}
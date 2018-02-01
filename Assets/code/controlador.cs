using UnityEngine;
using System.Collections;

public class controlador : MonoBehaviour {
	int multiplicador= 1;
	int Streak = 0;
	// Use this for initialization
	void Start () {
		PlayerPrefs.SetInt("Meta",43);
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Escape)){
			Application.LoadLevel("Portada");
		}
	}
	void OnTriggerEnter(Collider collision){
		 
	}
	public void AddStreak(){
		Debug.Log (PlayerPrefs.GetInt("Meta"));
		if (PlayerPrefs.GetInt ("Meta") + 1 < 70) {
			PlayerPrefs.SetInt("Meta",PlayerPrefs.GetInt("Meta")+2);
		}
		Streak++;
		if (Streak >= 24) {
			multiplicador = 4;
		} else if (Streak >= 16) {
			multiplicador = 3;
		} else if (Streak >= 8) {
			multiplicador = 2;
		} else {
			multiplicador=1;
		}
		UpdateGUI ();
	}

	public void ResetStreak(){
		PlayerPrefs.SetInt("Meta",PlayerPrefs.GetInt("Meta")-2);
		if(PlayerPrefs.GetInt("Meta")<=-17){
			lose();
		}
		multiplicador = 1;
		Streak = 0;
		UpdateGUI();
	}
	public void lose(){
		Application.LoadLevel("Portada");
	}
	public void win(){
		Application.LoadLevel("Portada");
	}

	void UpdateGUI(){
		PlayerPrefs.SetInt ("Streak",Streak);
		PlayerPrefs.SetInt ("Mult",multiplicador);
	}
	public int GetScore(){
		return (100*multiplicador);
	}
}

 using UnityEngine;
using System.Collections;

public class teletransporte : MonoBehaviour {
	
	public Transform destino;
	bool delantepuerta=false;
	bool teletransporta=false;

	void Update(){

		if (Input.GetKeyDown (KeyCode.E)&& delantepuerta){
			teletransporta=true;
		}
	}

	void OnTriggerEnter2D(Collider2D target){
		if (target.transform.tag == "Player"){
		delantepuerta=true;
		}
	}

	void OnTriggerStay2D(Collider2D target){

		if(teletransporta){
						target.transform.position = destino.position;
			teletransporta = false;
			delantepuerta = false;
		}
	}

	void OnTriggerExit2D(Collider2D target){
				if (target.transform.tag == "Player") {
						delantepuerta = false;
				}
		}


	void OnDrawGizmos(){
				if (destino != null) {
						Gizmos.color = Color.red;
						Gizmos.DrawLine (transform.position, destino.position);
				}
		}
}
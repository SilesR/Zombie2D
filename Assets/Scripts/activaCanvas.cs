﻿using UnityEngine;
using System.Collections;

public class activaCanvas: MonoBehaviour {

	public GameObject canvas;

	public bool estacerca=false;
	public bool mestratexto = false;



	// Update is called once per frame
	void Update () {
		if (estacerca) {
						canvas.SetActive (true);
				} else {
						canvas.SetActive (false);
				}
	
	}
	void OnTriggerEnter2D(Collider2D coll){
		if (coll.transform.tag == "Player"){
						estacerca = true;
				}
		}
	void OnTriggerExit2D(Collider2D coll){
		estacerca = false;
		}

}

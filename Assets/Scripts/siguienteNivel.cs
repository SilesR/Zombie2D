using UnityEngine;
using System.Collections;

public class siguienteNivel : MonoBehaviour {

	public string nombreNivel;
	bool cargando=false;
	public float tiempoEspera=3f;



	void OnTriggerStay2D(Collider2D target){
				if (target.transform.tag == "Player") {
						if (!cargando) {
								StartCoroutine (cargarNivel ());
						}
				}
		}

	void OnTriggerExit2D(Collider2D target){
		cargando = false;
		}

	IEnumerator cargarNivel(){
		cargando = true;
		yield return new WaitForSeconds(tiempoEspera);
		if(cargando){
			Application.LoadLevel(nombreNivel);

		}
}
}

using UnityEngine;
using System.Collections;

public class playerScript : MonoBehaviour {

	public float speed = 10f;
	public Vector2 maxVelocity = new Vector2(2,3);
	private Animator animacion;

	void Star(){

				//animator = GetComponent<Animator>();
		animacion = GetComponent<Animator>();
	
		}
	// Update is called once per frame
	void Update () {

				var absVelX = Mathf.Abs (rigidbody2D.velocity.x); //velocidad de eje x absoluta = a la velocidad que tenga el rigidbody

				var forceX = 0f;
				var forceY = 0f;
	
				//Calculate Veloity X
			if (Input.GetKey ("right")) {
				if(rigidbody2D.velocity.x <0){
					rigidbody2D.velocity= new Vector2 (0, rigidbody2D.velocity.y);//Si voy a la izquierda y cambio a la derecha freno.
				}
				if (absVelX < maxVelocity.x)
					forceX = speed;
				this.transform.localScale = new Vector3 (1, 1, 1);
			} else if (Input.GetKey ("left")) {
				if(rigidbody2D.velocity.x >0){
					rigidbody2D.velocity= new Vector2 (0, rigidbody2D.velocity.y);//Si voy a la derecha y cambio a la izquierda freno.
				}
				if (absVelX < maxVelocity.x)
					forceX = -speed;
				this.transform.localScale = new Vector3 (-1, 1, 1);
		}
		//Comparamos la velocidad actual para ssaber si es 0.
		if (absVelX > 0) {
			//animacion.SetFloat ("velocity", absVelX);
		}
		rigidbody2D.AddForce (new Vector2 (forceX, forceY));

		if (Input.GetKey ("c")) {
			//animacion.SetBool ("fire", true);
		} else {
			//animacion.SetBool ("fire", false);

		}

		}
	
}

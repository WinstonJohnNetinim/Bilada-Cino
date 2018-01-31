using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTruckAtual : MonoBehaviour {
	public Transform[] target;
	public float speed;
	private Rigidbody2D rb2d;
	private int current;
	private int vida = 10;
	private Vector2 direction = new Vector2(0, 5);

	// Use this for initialization
	void Start () {
		rb2d = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		rb2d.velocity =  this.direction * speed;
	}
		
	public void rotacionarCarro(int direcao){

		rb2d.transform.Rotate (new Vector3(0, 0, direcao * 90));
		if (direcao < 0)
			this.direction = new Vector2 (this.direction.y, this.direction.x);
		else if ( direcao > 0 )
			this.direction = - new Vector2 (this.direction.y, this.direction.x);
			

	}

	//Colisão ainda não funciona
	void OnCollisionEnter(Collision col){
		print ("Vida: " + vida);
		if(col.gameObject.tag == "Cilada")
		{
			vida = vida - 1;
			print ("Vida: " + vida);
			Destroy (col.gameObject);
		}
	}
}

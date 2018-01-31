using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StreetController : MonoBehaviour {

	public GameObject[] Side;
	private int index = 5;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	}

	public void setIndex(int index)
	{
		this.index = index;
		Debug.Log ("Entrada " + index);
	}

	public int chooseExit()
	{
		int exit;
		do {
			exit = Random.Range(0, Side.Length);
		}while(this.index == exit || Side[exit] == null);

		return exit;
	}

	private int chooseVector()
	{
		int exit = this.chooseExit ();
		//Debug.Log (exit);
		Debug.Log ("Saida " + exit);
		int decision = exit - this.index;

		if (decision % 2 == 0)
			return 0;
		else if (decision < 0)
			return -1;
		else
			return 1;
	}

	void OnTriggerEnter2D(Collider2D collisonInfo) {
		if(collisonInfo.CompareTag("Player")){
			collisonInfo.gameObject.GetComponent<MoveTruckAtual>().rotacionarCarro(this.chooseVector());
		}
	}
	
}

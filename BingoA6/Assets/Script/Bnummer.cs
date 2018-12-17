using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bnummer : MonoBehaviour {

	public string vak_aanduiding;
	private int vak_nummer;
 
	// Use this for initialization
	void Start () {
		vak_nummer = Random.Range(1,14);
		vak_aanduiding = "B" + vak_nummer;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Onummer : MonoBehaviour {

	//public string vak_aanduiding;
	private int vak_nummer;
	private TextMesh vak_aanduiding;
 
	// Use this for initialization
	void Start () {
		vak_nummer = Random.Range(58,70);
		// vak_aanduiding = "B" + vak_nummer;
		vak_aanduiding = gameObject.GetComponentInChildren(typeof(TextMesh)) as TextMesh;
		vak_aanduiding.text = "" + vak_nummer;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}



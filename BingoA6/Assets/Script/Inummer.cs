﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inummer : MonoBehaviour {

public Material [] material;  
public Renderer renderer;
public Color color;
	
	private int vak_nummer;
	private TextMesh vak_aanduiding;
 
	
	void Start () {
		vak_nummer = Random.Range(15,29);
		vak_aanduiding = gameObject.GetComponentInChildren(typeof(TextMesh)) as TextMesh;
		vak_aanduiding.text = "" + vak_nummer;
	}
	// Dit zorgt er voor dat de rij van de letter I op de bingo kaart allen de cijfers 15 t/m 29 kunnen krijgen.

	void OnMouseDown () {
		if (Input.GetMouseButtonDown(0)) {
      GetComponent<Renderer>().material.color = Color.red;
      }
      else {
      GetComponent<Renderer>().material.color = Color.white;
     }
// Dit zorgt er voor, dat de vakjes een rood kleurtje krijgen als je er op klikt, zodat je ze kn afvinken.
}
}


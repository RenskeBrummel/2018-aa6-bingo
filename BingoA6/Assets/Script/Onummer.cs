using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Onummer : MonoBehaviour {

public Material [] material;  
public Renderer renderer;
public Color color;
	
	private int vak_nummer;
	private TextMesh vak_aanduiding;
 
	
	void Start () {
		vak_nummer = Random.Range(58,70);
		
		vak_aanduiding = gameObject.GetComponentInChildren(typeof(TextMesh)) as TextMesh;
		vak_aanduiding.text = "" + vak_nummer;
	}
	// Dit zorgt er voor dat de rij van de letter O op de bingo kaart allen de cijfers 58 t/m 70 kunnen krijgen.
	
	void OnMouseDown () {
		if (Input.GetMouseButtonDown(0)) {
      GetComponent<Renderer>().material.color = Color.magenta;
      }
      else {
      GetComponent<Renderer>().material.color = Color.white;
     }
// Dit zorgt er voor, dat de vakjes een paars kleurtje krijgen als je er op klikt, zodat je ze kn afvinken.
}
}



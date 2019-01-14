using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bnummer : MonoBehaviour {

public Material [] material;  
public Renderer renderer;
public Color color;
	
	
	private int vak_nummer;
	private TextMesh vak_aanduiding;
 
	
	void Start () {
		vak_nummer = Random.Range(1,14);
		vak_aanduiding = gameObject.GetComponentInChildren(typeof(TextMesh)) as TextMesh;
		vak_aanduiding.text = "" + vak_nummer;
	}
	// Dit zorgt er voor dat de rij van de letter B op de bingo kaart allen de cijfers 1 t/m 14 kunnen krijgen.

	void OnMouseDown () {
		if (Input.GetMouseButtonDown(0)) {
      GetComponent<Renderer>().material.color = Color.green;
      }
      else {
      GetComponent<Renderer>().material.color = Color.white;
     }
// Dit zorgt er voor, dat de vakjes een groen kleurtje krijgen als je er op klikt, zodat je ze kn afvinken.

}
}


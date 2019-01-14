using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Radnummer : MonoBehaviour {

	
	private int rad_nummer;
	private TextMesh rad_aanduiding;
 
	 
	void Start () {
		rad_nummer = Random.Range(1,70);
		// Dit zorgt er voor dat hij een getal tussen 1 en 70 laat zien.
		rad_aanduiding = gameObject.GetComponentInChildren(typeof(TextMesh)) as TextMesh;
		if  (rad_nummer < 15 && rad_nummer > 1){
			rad_aanduiding.text = "B" + rad_nummer;
		} else if (rad_nummer < 29 && rad_nummer > 14) {
			rad_aanduiding.text = "I" + rad_nummer;
		} else if (rad_nummer < 44 && rad_nummer > 30) {
			rad_aanduiding.text = "N" + rad_nummer;
		} else if (rad_nummer < 58 && rad_nummer > 45) {
			rad_aanduiding.text = "G" + rad_nummer;
		} else if (rad_nummer < 71 && rad_nummer > 59) {
			rad_aanduiding.text = "O" + rad_nummer;
		}
	}
	// Dit zorgt er voor dat de getallen die bv. in de B rij staan ook de letter B voor het getal krijgen.
}



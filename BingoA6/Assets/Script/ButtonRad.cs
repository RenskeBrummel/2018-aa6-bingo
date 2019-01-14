using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonRad : MonoBehaviour {

private int bal_nummer;

private TextMesh bal_aanduiding;
private gameObject cube;

void Start() {
	bal_nummer = Random.Range(1,70);
	bal_aanduiding = gameObject.GetComponentInChildren(typeof(TextMesh)) as TextMesh;
		bal_aanduiding.text = "" + bal_nummer;
}
}

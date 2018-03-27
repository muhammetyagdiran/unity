using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yere_Basma : MonoBehaviour {
	ninjaHareket k;

	void Start () {
		k = transform.root.GetComponent<ninjaHareket> ();	
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D nesne){
		if (nesne.gameObject.tag == "collider") {
		k.yerdemi = true;
		}


}
}
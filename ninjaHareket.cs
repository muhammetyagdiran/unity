using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class ninjaHareket : MonoBehaviour {
	public float hiz;
	public float ziplama_gucu;
	Rigidbody2D fizik_karakter;
	public bool yerdemi;
	public Text skor;
	private float skorSayaci=0f;
	// Use this for initialization
	void Start () {
		fizik_karakter = GetComponent<Rigidbody2D> ();

	}
	
	// Update is called once per frame
	void Update () {
		if (skorSayaci >= 0f) {
			skorSayaci += Time.deltaTime;
			skor.text =  ""+(int)skorSayaci;
		} 
		transform.Translate(hiz*Time.deltaTime, 0, 0);
		transform.rotation = new Quaternion (0, 0, 0, 0);

	
		if (Input.GetKeyDown (KeyCode.Space)) {
			if (yerdemi) {
		
				fizik_karakter.velocity += new Vector2 (0, ziplama_gucu);
				yerdemi = false;
			}
		}
	
	}

		void OnTriggerEnter2D(Collider2D nesne){
		if (nesne.gameObject.tag == "gecis") {
			nesne.gameObject.transform.root.gameObject.GetComponent<yol> ().aktif=true;
		
		}
		if (nesne.gameObject.tag == "engel") {
			SceneManager.LoadScene ("sahne");
    
	
	}


}
}
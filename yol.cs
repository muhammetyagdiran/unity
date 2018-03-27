using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yol : MonoBehaviour {
	public GameObject[] objeler;
	public bool aktif;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (aktif) {
			Invoke ("yoluTasi",1.8f);
			aktif = false;

		}
	}
	void yoluTasi(){
		objeler [0].transform.localPosition = new Vector2 (Random.Range (43f, 50f),0);
		transform.position = transform.position+ new Vector3 (73f,0f, 0f);
	}



}

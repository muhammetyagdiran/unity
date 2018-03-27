using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour {
	GameObject karakter;
	public float x, y;
	// Use this for initialization
	void Start () {
		karakter = GameObject.FindGameObjectWithTag ("ninja");
	}
	
	// Update is called once per frame
	void Update () {
		
		transform.position = new Vector3 (karakter.transform.position.x+x,y,transform.position.z);
	}
}

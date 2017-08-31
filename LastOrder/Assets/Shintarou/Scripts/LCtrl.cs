using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LCtrl : MonoBehaviour
{

	public GameObject note;
	public GameObject circle;
	public GameObject AfterEffect;
	public GameObject miss;

	// Use this for initialization
	void Start ()
	{
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetMouseButtonDown (0) && circle.transform.localScale.x < 1.5) {
			Destroy (note.gameObject, 0);
			Instantiate (AfterEffect, note.transform.position, Quaternion.identity);
		}
		if (Input.GetMouseButtonDown (0) && circle.transform.localScale.x >= 1.5) {
			//Instantiate (miss, note.transform.position, Quaternion.identity);
			GameObject.Find ("HP").GetComponent<hP> ().HpDamage ();
		}
	}
		
}
     
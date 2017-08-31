using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class contactEnemy : MonoBehaviour
{
	//public int Speed;
	public GameObject blood;

	// Use this for initialization
	void Start ()
	{
		

	}
	// Update is called once per frame
	void Update ()
	{
		//transform.position -= transform.forward * Speed * Time.deltaTime;
	}

	void OnTriggerEnter (Collider other)
	{

		if (other.tag == "Enemy") {
			Destroy (other.gameObject);
			Destroy (this.gameObject);
			Instantiate (blood, transform.position, Quaternion.identity);
		}
	}

}


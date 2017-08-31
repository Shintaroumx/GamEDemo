using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sceneManager : MonoBehaviour
{

	// Use this for initialization
	public void loadMenu ()
	{
		Application.LoadLevel ("Demo");
	}

	public void quit ()
	{
		Application.Quit ();
	}

	void Update ()
	{
		if (Input.GetKey (KeyCode.Escape)) {
			Application.Quit ();
		}
	}
}

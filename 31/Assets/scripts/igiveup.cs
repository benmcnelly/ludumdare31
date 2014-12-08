using UnityEngine;
using System.Collections;

public class igiveup : MonoBehaviour {

	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey("escape"))
			Application.LoadLevel("main_menu");
	}
}

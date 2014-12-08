using UnityEngine;
using System.Collections;

public class detect_win : MonoBehaviour {


	void OnTriggerEnter(Collider coll) {
		if (coll.gameObject.name == "tankdrillthingy"){
			Debug.Log ("GAME OVER YALL");
			Application.LoadLevel("win");
		}
	} 


}

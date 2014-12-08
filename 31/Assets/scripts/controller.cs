using UnityEngine;
using System.Collections;

public class controller : MonoBehaviour {


	// OK, now expose some force variables to the inspector
	public int fowardForce      =  500;
	public int backwardForce    = -500;
	public int rotateLeftForce  = -400;
	public int rotateRightForce =  400;

// **************** LALALALALALA SLEEP IS STUPID ****** OK so, like variable states for stuff here ****



	// Don't move (we can call this maybe if no button is being clicked and we want a full stop?)
	public void powerNull() {
		//
	}

	public void powerForward(){
		rigidbody.AddForce(transform.forward * fowardForce, ForceMode.Force);
		//
	}

	public void powerBackward(){
		rigidbody.AddForce(transform.forward * backwardForce, ForceMode.Force);
		// transform.position += transform.forward * 10.0f * Time.deltaTime;
	}

	public void powerRotateLeft(){
		//
	}

	public void powerRotateRight(){
		//
	}


void Update () {

	if (Input.GetKey ("w")){
		powerForward();
	}

}


}

using UnityEngine;
using System.Collections;

namespace Assets.Scripts {
public class PlayerTouch : MonoBehaviour {


	void OnTriggerEnter(Collider col) {
	
			if (col.CompareTag ("Player")) {

				Affections.IsGrounded = true;
			
			} else {
			
				Affections.IsGrounded = false;
			
			}
	
		}
	}
}

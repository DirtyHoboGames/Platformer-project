using UnityEngine;
using System.Collections;
using UnityEngine.UI;

namespace Assets.Scripts {
public class PlayerMovement : MonoBehaviour {

		private GameObject player;

		public float HorizontalMultiplier = 1;
		public float VerticalMultiplier = 10;

		private Rigidbody rb = new Rigidbody ();



		/// <summary>
		/// With these you can modify the player's movement & jump force
		/// </summary>

		private Vector3 jump = new Vector3 (0, 1, 0);
		private Vector3 movement = new Vector3 (0, 0, 0);

		// Use this for initialization
		void Start () {

			player = GameObject.Find ("Player");
			rb = GameObject.Find ("Player/Player").GetComponent<Rigidbody> ();

		}
		
		// Update is called once per frame
		void Update () {

			getInput ();

			player.transform.Translate (movement);

			jump.Set (0, 1 * VerticalMultiplier, 0);
		
		}

		/// <summary>
		/// Gets the input from the player and turns that into a force that is later applied to a ball's rigidbody.
		/// </summary>
		void getInput() {

			if (Input.GetButton ("Jump")) {

						if (Affections.IsGrounded) {

						rb.AddForce(jump, ForceMode.Impulse);

						Affections.IsGrounded = false;

					}

			} else {
			
				movement.Set (Input.GetAxis ("Horizontal") * HorizontalMultiplier, 0, 0);
			
			}
		}
	}
}
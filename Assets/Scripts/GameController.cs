using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

namespace Assets.Scripts {
public class GameController : MonoBehaviour {

		// Use this for initialization
		void Start () {
		
		}
		
		// Update is called once per frame
		void Update () {
		
		}

		void OnLevelWasLoaded() {

			Debug.Log ("Level: " + Affections.CurrentMapIndex);

		}
	}
}

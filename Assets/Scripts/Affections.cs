using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

//This class is for every other class to access common variables and affections.
//For example, health and ammo count and whether the player is touching a platform or not.
namespace Assets.Scripts {
public class Affections : MonoBehaviour {

		public static float CurrentMapIndex = SceneManager.GetActiveScene().buildIndex;

		public static bool IsGrounded = true;

		public static bool HasAmmo = true;

		public static float AmmoCount = 120;

		public static bool Dead = false;

		public static float Health = 100;

	}
}
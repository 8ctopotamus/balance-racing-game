using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGame : MonoBehaviour {

	void OnTriggerEnter2D (Collider2D col) {
		if (col.CompareTag("Collidable")) {
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
		}
	}

}

using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGame : MonoBehaviour {

	void OnTriggerEnter2D () {
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
	}

}

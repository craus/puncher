using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    void Awake() {
        Debug.LogFormat("I am compiling");
    }

	void Update() {
        if (Input.GetButtonDown("Restart")) {
            Debug.LogFormat("Restarting");
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
	}
}

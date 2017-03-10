using UnityEngine;
using UnityEngine.SceneManagement;

public class levelLoad : MonoBehaviour {


	public void LoadLevel(string level){

		SceneManager.LoadScene(level);
	}
}

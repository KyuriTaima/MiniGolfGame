

using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoalDetection : MonoBehaviour {


	public TextMesh text;
	private bool endlevel = false;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown("space") && endlevel == true){
			SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex + 1);
		}
	}

	private void OnCollisionEnter(Collision other) {
		int tries = BallShooting.tries;
		Debug.Log("You managed to win in " + tries + " tries");
		Golfer.level++;
		Golfer.score = Golfer.score + tries;
		Debug.Log("Your score is " + Golfer.score);
		if(SceneManager.GetActiveScene().buildIndex <= SceneManager.sceneCount){
			text.text = "Congratulations, you finished this level in " + tries + " tries. Press spacebar to continue";
			endlevel = true;
		}else{
			text.text = "Congratulations, you finished the game with " + Golfer.score + " points";
		}
		
	}
}

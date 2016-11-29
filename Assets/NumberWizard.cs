using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class NumberWizard : MonoBehaviour {
	// Var Initialization
	int max;
	int min;
	int guess;
	
	//Settings
	public int maxGuessesAllowed = 5;

	//UI
	public Text guessText;
	
	// Game Start
	void Start () {
		StartGame();
	}
	
	void StartGame() { 
		max = 1000;
		min = 1;
		guess = Random.Range(min, max+1);
		guessText.text = guess.ToString();
	}
	
	public void GuessHigher () { 
		min = guess;
		NextGuess();
	}
	
	public void GuessLower () { 
		max = guess;
		NextGuess();
	}
	
	void NextGuess() { 
		guess = Random.Range(min, max+1);
		guessText.text = guess.ToString();
		maxGuessesAllowed = maxGuessesAllowed - 1;
		if (maxGuessesAllowed <= 0) { 
			Application.LoadLevel("Win");
		}
	}
}

using UnityEngine;
using System.Collections;

public class NumberWizard : MonoBehaviour {

	// Use this for initialization
	int max;
	int min;
	int guess;
	
	void Start () {
		StartGame ();
	}
	
	void StartGame () {
		max = 1000;
		min = 1;
		guess = 500;
		
		print ("=========================");
		print ("Welcome to Number Wizard");
		print ("Pick a number in your head..but do not tell me!");
		
		print ("The highest number you can pick is " + max);
		print ("The lowest number you can pick is " + min);
		
		print ("Is the number higher or lower than " + guess + "?");
		
		max = max + 1; //This allows user to pick a thousand
	}
	
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.UpArrow)){ //result is the up arrow key coe
			//print("Up arrow pressed");
			min = guess; //this is where you set min = 500 = guess
			NextGuess ();
		} else if (Input.GetKeyDown(KeyCode.DownArrow)){ //result is the down arrow key coe
			//print("Down arrow pressed");
			max = guess; //this is where you set min = 500 = guess
			NextGuess ();
		} else if (Input.GetKeyDown(KeyCode.Return)){
			print("I won!");
			StartGame();
			
		}
	}
	
	void NextGuess (){
			guess = (max + min) / 2; //sets to be halfway between the max and min
			print ("Higher or lower that " + guess);
			print ("Up = higher, down = lower, return = equal");
		
	}	
}
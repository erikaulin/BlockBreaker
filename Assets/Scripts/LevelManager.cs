using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {

	public void LoadLevel(string name){
		Debug.Log("New Level load: "+ name);
		Application.LoadLevel (name);
	}

	public void QuitRequest(){
		Debug.Log("Quit requested");
		Application.Quit();
	}
	
	public void Higher(){
		Debug.Log("Number is higher then: ");
		Application.LoadLevel(name);
	}
	
	public void Lower(){
		Debug.Log("Number is lower then: ");
		Application.LoadLevel(name);
	}
	
	public void Equal(){
		Debug.Log("You win!");
		Application.LoadLevel(name);
	}
}

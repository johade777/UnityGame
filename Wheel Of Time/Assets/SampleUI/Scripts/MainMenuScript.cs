using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class MainMenuScript : MonoBehaviour {
	public Canvas creditsMenu;
	public Canvas settingsMenu;
	public Canvas mainMenu;

	public Button newGameText;
	public Button loadGameText;
	public Button creditsText;
	public Button settingsText;
	public Button quitText;

	// Use this for initialization
	void Start () {
		mainMenu = mainMenu.GetComponent<Canvas> ();
		creditsMenu = creditsMenu.GetComponent<Canvas> ();
		settingsMenu = settingsMenu.GetComponent<Canvas> ();

		newGameText = newGameText.GetComponent<Button> ();
		loadGameText = loadGameText.GetComponent<Button> ();
		creditsText = creditsText.GetComponent<Button> ();
		settingsText = settingsText.GetComponent<Button> ();
		quitText = quitText.GetComponent<Button> ();

		creditsMenu.enabled = false;
		settingsMenu.enabled = false;
	}

	public void startGame(){
		Debug.Log ("New Game Pressed");
		//SceneManager.LoadScene (1);
	}

	public void loadGamePressed(){
		Debug.Log ("Loading Game");
		//SceneManager.LoadScene (1);
	}

	public void creditsPress(){
		mainMenu.enabled = false;
		settingsMenu.enabled = false;
		creditsMenu.enabled = true;
	}

	public void settingsPress(){
		mainMenu.enabled = false;
		creditsMenu.enabled = false;
		settingsMenu.enabled = true;
	}

	public void creditsDonePress(){
		creditsMenu.enabled = false;
		mainMenu.enabled = true;
	}

	public void settingsDonePress(){
		settingsMenu.enabled = false;
		mainMenu.enabled = true;
	}

	public void exitGame (){
		Debug.Log ("Quit Pressed");
		Application.Quit ();
	}
}

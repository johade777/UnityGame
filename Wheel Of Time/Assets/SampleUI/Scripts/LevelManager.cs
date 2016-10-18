using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class LevelManager : MonoBehaviour {
	public Transform mainMenu, settingsMenu, creditsMenu;

	public void LoadScene(string name){
		SceneManager.LoadScene (name);
	}

	public void Quit(){
		Application.Quit();
	}

	public void SettingMenu(bool clicked){
		if (clicked) {
			settingsMenu.gameObject.SetActive (clicked);
			mainMenu.gameObject.SetActive (false);
		} else {
			settingsMenu.gameObject.SetActive (clicked);
			mainMenu.gameObject.SetActive (true);
		}
	}

	public void CreditsMenu(bool clicked){
		if (clicked) {
			creditsMenu.gameObject.SetActive (clicked);
			mainMenu.gameObject.SetActive (false);
		} else {
			creditsMenu.gameObject.SetActive (clicked);
			mainMenu.gameObject.SetActive (true);
		}
	}
}

﻿using UnityEngine;
using System.Collections;

public class QuitOnClick : MonoBehaviour {

	public void quitOnClick(){
		#if UNITY_EDITOR
			UnityEditor.EditorApplication.isPlaying = false;
		#else
			Application.Quit();
		#endif
	}
}

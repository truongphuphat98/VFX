using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

namespace UI
{

    public class UI_MainMenu : MonoBehaviour
    {

		public GameObject loadScreen;

        public void StartGame()
        {
			loadScreen.SetActive (true);
            Application.LoadLevel(1);
        }

        public void ExitGame()
        {
            Application.Quit();
        }
    }
}

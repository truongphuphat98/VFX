using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

namespace UI
{
    public class UI_ExitGame : MonoBehaviour
    {
        public void BackToMainMenu()
        {
            Application.LoadLevel(0);
        }
    }
}

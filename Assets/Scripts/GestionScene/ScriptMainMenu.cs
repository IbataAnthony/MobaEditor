using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScriptMainMenu : MonoBehaviour
{
     public void GoToSceneGame()
    {

        SceneManager.LoadScene("SampleScene");
    }
}

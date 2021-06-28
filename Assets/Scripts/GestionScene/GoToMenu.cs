using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToMenu : MonoBehaviour
{

    public Camera cam1;
    public Camera cam2;
    public Canvas hud;
    public Canvas creaHud;
    public Canvas menuHud;
    void Start()
    {
        cam1.enabled = true;
        cam2.enabled = false;
    }

    /*function Update()
    {

        if (Input.GetKeyDown(KeyCode.C))
        {
            cam1.enabled = !cam1.enabled;
            cam2.enabled = !cam2.enabled;
        }
    }*/

    public void GoToSceneGame()
    {
        cam1.enabled = false;
        cam2.enabled = true;
        menuHud.enabled = true;
        hud.enabled = false;
        creaHud.enabled = false;
        //SceneManager.LoadScene("SceneMainMenu");
    }
}
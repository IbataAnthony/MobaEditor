
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScriptCreationCharac : MonoBehaviour
{


    GameObject player;
    public Camera cam1;
    public Camera cam2;
    public Canvas hud;
    public Canvas creaHud;
    public Canvas menuHud;
    public GameObject resp;



    void Start()
    {
        creaHud.enabled = false;
        cam1.enabled = true;
        cam2.enabled = true;
        player = GameObject.FindGameObjectWithTag("Player");
    }

    /*function Update() {
 
		if (Input.GetKeyDown(KeyCode.C)) {
			cam1.enabled =  !cam1.enabled; 
			cam2.enabled = !cam2.enabled;
		}
	}*/

    public void GoToSceneGame()
    {

       
        player.transform.position = resp.transform.position;
        cam1.enabled = !cam1.enabled;
        cam2.enabled = !cam2.enabled;
        hud.enabled = !hud.enabled;
        menuHud.enabled = false;
        creaHud.enabled = !creaHud.enabled;
        //SceneManager.LoadScene("SceneMainMenu");
    }
}
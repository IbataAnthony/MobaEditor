using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScriptStartGame : MonoBehaviour
{


    GameObject player;
    public Camera cam1;
    public Camera cam2;
    public Canvas hud;
    public Canvas menuHud;
    public Canvas creaHud;
    public GameObject resp;


    private UnityEngine.AI.NavMeshAgent agent;

    void Start()
    {
        cam1.enabled = true;
        cam2.enabled = true;
        player = GameObject.FindGameObjectWithTag("Player");
        creaHud.enabled = false;
        agent = player.GetComponent<UnityEngine.AI.NavMeshAgent>();
    }

    /*function Update() {
 
		if (Input.GetKeyDown(KeyCode.C)) {
			cam1.enabled = !cam1.enabled;
			cam2.enabled = !cam2.enabled;
		}
	}*/

    public void GoToSceneGame()
    {

        player.transform.position = resp.transform.position;


        cam1.enabled = true;
        cam2.enabled = false;

      
        hud.enabled = true;
        creaHud.enabled = false;
        menuHud.enabled = false;
        agent.SetDestination(resp.transform.position);

        //SceneManager.LoadScene("SceneMainMenu");
    }
}
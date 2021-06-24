using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TransfertCapsule : MonoBehaviour
{
    // Type in the name of the Scene you would like to load in the Inspector
    public string sampleScene = "SampleScene";

    // Assign your GameObject you want to move Scene in the Inspector
    public GameObject m_MyGameObject;
    /*public Hero hero;
    public HeroCombat heroCombat;
    public Movement movement;*/


  public void goToSampleScene()
        {
            StartCoroutine(LoadYourAsyncScene());
       /* hero = (Hero) m_MyGameObject.AddComponent(typeof(Hero));
        heroCombat = (HeroCombat)m_MyGameObject.AddComponent(typeof(HeroCombat));
        movement = (Movement)m_MyGameObject.AddComponent(typeof(Movement));*/

    }
    

    IEnumerator LoadYourAsyncScene()
    {
        // Set the current Scene to be able to unload it later
        Scene currentScene = SceneManager.GetActiveScene();

        // The Application loads the Scene in the background at the same time as the current Scene.
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(sampleScene, LoadSceneMode.Additive);

        // Wait until the last operation fully loads to return anything
        while (!asyncLoad.isDone)
        {
            yield return null;
        }

        // Move the GameObject (you attach this in the Inspector) to the newly loaded Scene
        SceneManager.MoveGameObjectToScene(m_MyGameObject, SceneManager.GetSceneByName(sampleScene));
        // Unload the previous Scene
        SceneManager.UnloadSceneAsync(currentScene);
    }
}
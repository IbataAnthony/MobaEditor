using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIAttack : MonoBehaviour
{
    public GameObject attack1;
    public GameObject attack2;
    public GameObject attack3;
    public GameObject text1;
    public GameObject text2;
    public GameObject text3;
    int numeroSort = 1;

    private void Start()
    {
        attack1.gameObject.SetActive(true);
        text1.gameObject.SetActive(true);
        attack2.gameObject.SetActive(false);
        text2.gameObject.SetActive(false);
        attack3.gameObject.SetActive(false);
        text3.gameObject.SetActive(false);
    }
    void Update()
    {
        switch (numeroSort)
        {
            case 1:
                attack1.gameObject.SetActive(true);
                text1.gameObject.SetActive(true);

                attack2.gameObject.SetActive(false);
                text2.gameObject.SetActive(false);

                attack3.gameObject.SetActive(false);
                text3.gameObject.SetActive(false);

                break;
            case 2:
                attack1.gameObject.SetActive(false);
                text1.gameObject.SetActive(false);

                attack2.gameObject.SetActive(true);
                text2.gameObject.SetActive(true);

                attack3.gameObject.SetActive(false);
                text3.gameObject.SetActive(false);

                break;
            case 3:
                attack1.gameObject.SetActive(false);
                text1.gameObject.SetActive(false);

                attack2.gameObject.SetActive(false);
                text2.gameObject.SetActive(false);

                attack3.gameObject.SetActive(true);
                text3.gameObject.SetActive(true);

                break;
            default:
                print("erreur");
                break;
        }
    }

    public void next()
    {
        if(numeroSort<3) numeroSort++;
       
    }

    public void previous()
    {
        if (numeroSort > 1) numeroSort--;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UICompE : MonoBehaviour
{
    GameObject[] player;
    public GameObject compE1;
    public GameObject compE2;
    public GameObject compE3;
    public GameObject text1;
    public GameObject text2;
    public GameObject text3;
    int numeroCompE = 1;
    CompE compe;
    public CreationCharac creationCharac;
    public CompE exemple1;
    public CompE exemple2;
    public CompE exemple3;

    private void Start()
    {

        player = GameObject.FindGameObjectsWithTag("Player");
        creationCharac = player[0].GetComponent(typeof(CreationCharac)) as CreationCharac;
        compe = player[0].GetComponent(typeof(CompE)) as CompE;


        compE1.gameObject.SetActive(true);
        text1.gameObject.SetActive(true);

        compE2.gameObject.SetActive(false);
        text2.gameObject.SetActive(false);

        compE3.gameObject.SetActive(false);
        text3.gameObject.SetActive(false);


    }
    void Update()
    {
        switch (numeroCompE)
        {
            case 1:
                compE1.gameObject.SetActive(true);
                text1.gameObject.SetActive(true);

                compE2.gameObject.SetActive(false);
                text2.gameObject.SetActive(false);

                compE3.gameObject.SetActive(false);
                text3.gameObject.SetActive(false);

                break;
            case 2:
                compE1.gameObject.SetActive(false);
                text1.gameObject.SetActive(false);

                compE2.gameObject.SetActive(true);
                text2.gameObject.SetActive(true);

                compE3.gameObject.SetActive(false);
                text3.gameObject.SetActive(false);

                break;
            case 3:
                compE1.gameObject.SetActive(false);
                text1.gameObject.SetActive(false);

                compE2.gameObject.SetActive(false);
                text2.gameObject.SetActive(false);

                compE3.gameObject.SetActive(true);
                text3.gameObject.SetActive(true);

                break;
            default:
                print("erreur");
                break;
        }
    }

    public void next()
    {
        if (numeroCompE < 3) numeroCompE++;

    }

    public void previous()
    {
        if (numeroCompE > 1) numeroCompE--;
    }
    public void apply()
    {
        compe.set = numeroCompE;

    }
}
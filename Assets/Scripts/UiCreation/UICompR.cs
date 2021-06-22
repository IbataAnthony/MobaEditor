using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UICompR : MonoBehaviour
{
    public GameObject compR1;
    public GameObject compR2;
    public GameObject compR3;
    public GameObject text1;
    public GameObject text2;
    public GameObject text3;
    int numeroCompR = 1;
    public CreationCharac creationCharac;
    CompR exemple1;
    CompR exemple2;
    CompR exemple3;


    private void Start()
    {
        compR1.gameObject.SetActive(true);
        text1.gameObject.SetActive(true);

        compR2.gameObject.SetActive(false);
        text2.gameObject.SetActive(false);

        compR3.gameObject.SetActive(false);
        text3.gameObject.SetActive(false);


    }
    void Update()
    {
        switch (numeroCompR)
        {
            case 1:
                compR1.gameObject.SetActive(true);
                text1.gameObject.SetActive(true);

                compR2.gameObject.SetActive(false);
                text2.gameObject.SetActive(false);

                compR3.gameObject.SetActive(false);
                text3.gameObject.SetActive(false);

                break;
            case 2:
                compR1.gameObject.SetActive(false);
                text1.gameObject.SetActive(false);

                compR2.gameObject.SetActive(true);
                text2.gameObject.SetActive(true);

                compR3.gameObject.SetActive(false);
                text3.gameObject.SetActive(false);

                break;
            case 3:
                compR1.gameObject.SetActive(false);
                text1.gameObject.SetActive(false);

                compR2.gameObject.SetActive(false);
                text2.gameObject.SetActive(false);

                compR3.gameObject.SetActive(true);
                text3.gameObject.SetActive(true);

                break;
            default:
                print("erreur");
                break;
        }
    }

    public void next()
    {
        if (numeroCompR < 3) numeroCompR++;

    }

    public void previous()
    {
        if (numeroCompR > 1) numeroCompR--;
    }
    public void apply()
    {
        switch (numeroCompR)
        {
            case 1: creationCharac.setCompR(exemple1); break;
            case 2: creationCharac.setCompR(exemple2); break;
            case 3: creationCharac.setCompR(exemple3); break;
            default: print("error choix competence R"); break;
        }

    }
}
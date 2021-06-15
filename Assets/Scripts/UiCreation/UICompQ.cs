using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UICompQ : MonoBehaviour
{
    public GameObject compQ1;
    public GameObject compQ2;
    public GameObject compQ3;
    public GameObject text1;
    public GameObject text2;
    public GameObject text3;
    int numeroCompQ = 1;

    private void Start()
    {
        compQ1.gameObject.SetActive(true);
        text1.gameObject.SetActive(true);

        compQ2.gameObject.SetActive(false);
        text2.gameObject.SetActive(false);

        compQ3.gameObject.SetActive(false);
        text3.gameObject.SetActive(false);


    }
    void Update()
    {
        switch (numeroCompQ)
        {
            case 1:
                compQ1.gameObject.SetActive(true);
                text1.gameObject.SetActive(true);

                compQ2.gameObject.SetActive(false);
                text2.gameObject.SetActive(false);

                compQ3.gameObject.SetActive(false);
                text3.gameObject.SetActive(false);

                break;
            case 2:
                compQ1.gameObject.SetActive(false);
                text1.gameObject.SetActive(false);

                compQ2.gameObject.SetActive(true);
                text2.gameObject.SetActive(true);

                compQ3.gameObject.SetActive(false);
                text3.gameObject.SetActive(false);

                break;
            case 3:
                compQ1.gameObject.SetActive(false);
                text1.gameObject.SetActive(false);

                compQ2.gameObject.SetActive(false);
                text2.gameObject.SetActive(false);

                compQ3.gameObject.SetActive(true);
                text3.gameObject.SetActive(true);

                break;
            default:
                print("erreur");
                break;
        }
    }

    public void next()
    {
        if (numeroCompQ < 3) numeroCompQ++;

    }

    public void previous()
    {
        if (numeroCompQ > 1) numeroCompQ--;
    }
}

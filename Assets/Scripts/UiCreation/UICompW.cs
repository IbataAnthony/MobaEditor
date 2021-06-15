using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UICompW : MonoBehaviour
{
    public GameObject compW1;
    public GameObject compW2;
    public GameObject compW3;
    public GameObject text1;
    public GameObject text2;
    public GameObject text3;
    int numeroCompW = 1;

    private void Start()
    {
        compW1.gameObject.SetActive(true);
        text1.gameObject.SetActive(true);

        compW2.gameObject.SetActive(false);
        text2.gameObject.SetActive(false);

        compW3.gameObject.SetActive(false);
        text3.gameObject.SetActive(false);


    }
    void Update()
    {
        switch (numeroCompW)
        {
            case 1:
                compW1.gameObject.SetActive(true);
                text1.gameObject.SetActive(true);

                compW2.gameObject.SetActive(false);
                text2.gameObject.SetActive(false);

                compW3.gameObject.SetActive(false);
                text3.gameObject.SetActive(false);

                break;
            case 2:
                compW1.gameObject.SetActive(false);
                text1.gameObject.SetActive(false);

                compW2.gameObject.SetActive(true);
                text2.gameObject.SetActive(true);

                compW3.gameObject.SetActive(false);
                text3.gameObject.SetActive(false);

                break;
            case 3:
                compW1.gameObject.SetActive(false);
                text1.gameObject.SetActive(false);

                compW2.gameObject.SetActive(false);
                text2.gameObject.SetActive(false);

                compW3.gameObject.SetActive(true);
                text3.gameObject.SetActive(true);

                break;
            default:
                print("erreur");
                break;
        }
    }

    public void next()
    {
        if (numeroCompW < 3) numeroCompW++;

    }

    public void previous()
    {
        if (numeroCompW > 1) numeroCompW--;
    }
}
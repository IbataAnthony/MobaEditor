using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CompE : MonoBehaviour
{

    public Image imageBase1;
    public Image imageSombre1;
    public Image imageBase2;
    public Image imageSombre2;
    public Image imageBase3;
    public Image imageSombre3;
    public Charac charac;
    public float set;

    // Start is called before the first frame update
    public void Start()
    {

    }


    // Update is called once per frame
    public void Update()
    {

    }


    public void Launch()
    {
        switch (set)
        {
            case 1: Launch1(); break;
            case 2: Launch2(); break;
            default: Launch3(); break;
        }
    }

    public void Launch1()
    {
        charac.setCurrentHp(charac.getMaxHp().ToString());
        Debug.Log("CompEHealth lanc?e");
    }
    
    public void Launch2()
    {
        charac.setCurrentHp(charac.getMaxHp().ToString());
        Debug.Log("CompEHealth lanc?e");
    }

    public void Launch3()
    {
        charac.setCurrentHp(charac.getMaxHp().ToString());
        Debug.Log("CompEHealth lanc?e");
    }
}
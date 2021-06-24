using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CompQ : MonoBehaviour
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
    IEnumerator Invu()
    {
        float a = charac.getAttack();
        charac.setDamage((charac.getAttack() * 1.2).ToString());
        yield return new WaitForSeconds(5);
        charac.setDamage(a.ToString());
    }

    public void Launch1()
    {
        StartCoroutine(Invu());
        Debug.Log("CompQInvu1 launch");
    }



    public void Launch2()
    {
        charac.setDamage((charac.getAttack() * 1.2).ToString());
        Debug.Log("CompQdamage2 lancée");
    }

    public void Launch3()
    {
        charac.setDamage((charac.getAttack() * 1.2).ToString());
        Debug.Log("CompQdamage3 lancée");
    }
}
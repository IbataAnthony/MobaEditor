using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CompW : MonoBehaviour
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
        StartCoroutine(Invu());
        Debug.Log("CompWInvu lancée");
    }

    public void Launch2()
    {
        StartCoroutine(Armor50());
        Debug.Log("CompWArmor50 lancée");
    }

    public void Launch3()
    {
        StartCoroutine(Armor25());
        Debug.Log("CompWArmor25 lancée");
    }

    IEnumerator Invu()
    {
        float tmp = charac.getArmor();
        charac.setArmor((charac.getArmor() * 100).ToString());
        yield return new WaitForSeconds(5);
        charac.setArmor(tmp.ToString());
    }

    IEnumerator Armor50()
    {
        float tmp = charac.getArmor();
        charac.setArmor((charac.getArmor() + charac.getArmor() * 50 / 100).ToString());
        yield return new WaitForSeconds(10);
        charac.setArmor(tmp.ToString());
    }

    IEnumerator Armor25()
    {
        float tmp = charac.getArmor();
        charac.setArmor((charac.getArmor() + charac.getArmor() * 25 / 100).ToString());
        yield return new WaitForSeconds(25);
        charac.setArmor(tmp.ToString());
    }
}
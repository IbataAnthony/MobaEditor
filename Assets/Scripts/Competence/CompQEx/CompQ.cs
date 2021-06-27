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


    // Update is called once pe r frame
    public void Update()
    {

    }


    public void Launch()
    {
        switch (set)
        {
            case 1: BuffDgt(); break;
            case 2: Beserker(); break;
            case 3: BuffDgtHp(); break;

        }
    }
    IEnumerator Invu1()
    {
        float a = charac.getAttack();
        charac.setDamage((charac.getAttack() * 1.2).ToString());
        yield return new WaitForSeconds(5);
        charac.setDamage(a.ToString());
    }
    IEnumerator Invu2()
    {
        float a = charac.getAttack();
        float b = (charac.getCurrentHp()) / charac.getMaxHp();
        float x = 1;
        if (b != 1)
        {
            charac.setDamage((charac.getAttack() * (x + (x - b))).ToString());

        }
        else { }
        if (charac.getCurrentHp() <= 0) { yield return new WaitForSeconds(0); }
        yield return new WaitForSeconds(5);
        charac.setDamage(a.ToString());
    }


    IEnumerator Invu3()
    {
        float a = charac.getAttack();
        charac.setDamage((charac.getAttack() + (charac.getCurrentHp() * 0.05)).ToString());
        yield return new WaitForSeconds(5);
        charac.setDamage(a.ToString());
    }


    public void BuffDgt()
    {
        StartCoroutine(Invu1());
        Debug.Log("CompQInvu1 launch");
    }



    public void Beserker()
    {
        StartCoroutine(Invu2());
        Debug.Log("CompQdamage2 launch");
    }

    public void BuffDgtHp()
    {

        StartCoroutine(Invu3());
        Debug.Log("CompQdamage3 launch");

    }
}
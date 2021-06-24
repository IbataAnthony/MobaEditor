using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;
using UnityEngine.UI;

public class GestAbilities : MonoBehaviour
{
    public GameObject Capsule;
    public CompQ Comp1;
    public CompW Comp2;
    public CompE Comp3;
    public CompR Comp4;

    [Header("Ability 1")]
    public Image Comp1Clair;
    public Image Comp1Sombre;
    public float cooldown1 = 5;
    bool isCooldown1 = false;
    public KeyCode ability1;

    [Header("Ability 2")]
    public Image Comp2Clair;
    public Image Comp2Sombre;
    public float cooldown2 = 10;
    bool isCooldown2 = false;
    public KeyCode ability2;

    [Header("Ability 3")]
    public Image Comp3Clair;
    public Image Comp3Sombre;
    public float cooldown3 = 7;
    bool isCooldown3 = false;
    public KeyCode ability3;

    [Header("Ability 4")]
    public Image Comp4Clair;
    public Image Comp4Sombre;
    public float cooldown4 = 10;
    bool isCooldown4 = false;
    public KeyCode ability4;

    // Start is called before the first frame update
    void Start()
    {
        Comp1.imageBase1.gameObject.SetActive(false);
        Comp1.imageSombre1.gameObject.SetActive(false);
        Comp1.imageBase2.gameObject.SetActive(false);
        Comp1.imageSombre2.gameObject.SetActive(false);
        Comp1.imageBase3.gameObject.SetActive(false);
        Comp1.imageSombre3.gameObject.SetActive(false);
        Comp2.imageBase1.gameObject.SetActive(false);
        Comp2.imageSombre1.gameObject.SetActive(false);
        Comp2.imageBase2.gameObject.SetActive(false);
        Comp2.imageSombre2.gameObject.SetActive(false);
        Comp2.imageBase3.gameObject.SetActive(false);
        Comp2.imageSombre3.gameObject.SetActive(false);
        Comp3.imageBase1.gameObject.SetActive(false);
        Comp3.imageSombre1.gameObject.SetActive(false);
        Comp3.imageBase2.gameObject.SetActive(false);
        Comp3.imageSombre2.gameObject.SetActive(false);
        Comp3.imageBase3.gameObject.SetActive(false);
        Comp3.imageSombre3.gameObject.SetActive(false);
        Comp4.imageBase1.gameObject.SetActive(false);
        Comp4.imageSombre1.gameObject.SetActive(false);
        Comp4.imageBase2.gameObject.SetActive(false);
        Comp4.imageSombre2.gameObject.SetActive(false);
        Comp4.imageBase3.gameObject.SetActive(false);
        Comp4.imageSombre3.gameObject.SetActive(false);


        switch (Comp1.set)
        {
            case 1: Comp1Sombre = Comp1.imageSombre1; Comp1Clair = Comp1.imageBase1; break;
            case 2: Comp1Sombre = Comp1.imageSombre2; Comp1Clair = Comp1.imageBase2; break;
            default: Comp1Sombre = Comp1.imageSombre3; Comp1Clair = Comp1.imageBase3; break;
        }
        Comp1Sombre.gameObject.SetActive(true);
        Comp1Clair.gameObject.SetActive(true);

        switch (Comp2.set)
        {
            case 1: Comp2Sombre = Comp2.imageSombre1; Comp2Clair = Comp2.imageBase1; break;
            case 2: Comp2Sombre = Comp2.imageSombre2; Comp2Clair = Comp2.imageBase2; break;
            default: Comp2Sombre = Comp2.imageSombre3; Comp2Clair = Comp2.imageBase3; break;
        }
        Comp2Sombre.gameObject.SetActive(true);
        Comp2Clair.gameObject.SetActive(true);


        switch (Comp3.set)
        {
            case 1: Comp3Sombre = Comp3.imageSombre1; Comp3Clair = Comp3.imageBase1; break;
            case 2: Comp3Sombre = Comp3.imageSombre2; Comp3Clair = Comp3.imageBase2; break;
            default: Comp3Sombre = Comp3.imageSombre3; Comp3Clair = Comp3.imageBase3; break;
        }
        Comp3Sombre.gameObject.SetActive(true);
        Comp3Clair.gameObject.SetActive(true);


        switch (Comp4.set)
        {
            case 1: Comp4Sombre = Comp4.imageSombre1; Comp4Clair = Comp4.imageBase1; break;
            case 2: Comp4Sombre = Comp4.imageSombre2; Comp4Clair = Comp4.imageBase2; break;
            default: Comp4Sombre = Comp4.imageSombre3; Comp4Clair = Comp4.imageBase3; break;
        }
        Comp4Sombre.gameObject.SetActive(true);
        Comp4Clair.gameObject.SetActive(true);



        Comp1Sombre.fillAmount = 0;
        Comp2Sombre.fillAmount = 0;
        Comp3Sombre.fillAmount = 0;
        Comp4Sombre.fillAmount = 0;

        Comp1.Start();
        Comp2.Start();
        Comp3.Start();
        Comp4.Start();
    }

    // Update is called once per frame
    void Update()
    {
        Ability1();
        Ability2();
        Ability3();
        Ability4();
    }

    void Ability1()
    {
        if (Input.GetKey(ability1) && isCooldown1 == false)
        {
            Comp1.Launch();
            Debug.Log("Comp1 lancée");
            isCooldown1 = true;
            Comp1Sombre.fillAmount = 1;
        }
        if (isCooldown1)
        {
            Comp1Sombre.fillAmount -= 1 / cooldown1 * Time.deltaTime;
            //Debug.Log("Comp1 Cooldown :" + 1 / cooldown1 * Time.deltaTime);
            //Activate indicators here

            if (Comp1Sombre.fillAmount <= 0)
            {
                Comp1Sombre.fillAmount = 0;
                isCooldown1 = false;
                Debug.Log("Comp1 prête");
            }
        }
    }

    void Ability2()
    {
        if (Input.GetKey(ability2) && isCooldown2 == false)
        {
            Comp2.Launch();
            Debug.Log("Comp2 lancée");
            isCooldown2 = true;
            Comp2Sombre.fillAmount = 1;
        }
        if (isCooldown2)
        {
            Comp2Sombre.fillAmount -= 1 / cooldown2 * Time.deltaTime;
            //Debug.Log("Comp2 Cooldown :" + 1 / cooldown2 * Time.deltaTime);
            //Activate indicators here

            if (Comp2Sombre.fillAmount <= 0)
            {
                Comp2Sombre.fillAmount = 0;
                isCooldown2 = false;
                Debug.Log("Comp2 prête");
            }
        }
    }


    void Ability3()
    {
        if (Input.GetKey(ability3) && isCooldown3 == false)
        {
            Comp3.Launch();
            Debug.Log("Comp3 lancée");
            isCooldown3 = true;
            Comp3Sombre.fillAmount = 1;
        }
        if (isCooldown3)
        {
            Comp3Sombre.fillAmount -= 1 / cooldown3 * Time.deltaTime;
            //Debug.Log("Comp3 Cooldown :" + 1 / cooldown3 * Time.deltaTime);
            //Activate indicators here

            if (Comp3Sombre.fillAmount <= 0)
            {
                Comp3Sombre.fillAmount = 0;
                isCooldown3 = false;
                Debug.Log("Comp3 prête");
            }
        }
    }

    void Ability4()
    {
        if (Input.GetKey(ability4) && isCooldown4 == false)
        {
            Comp4.Launch();
            Debug.Log("Comp4 lancée");
            isCooldown4 = true;
            Comp4Sombre.fillAmount = 1;
        }
        if (isCooldown4)
        {
            Comp4Sombre.fillAmount -= 1 / cooldown4 * Time.deltaTime;
            //Debug.Log("Comp4 Cooldown :" + 1 / cooldown4 * Time.deltaTime);
            //Activate indicators here

            if (Comp4Sombre.fillAmount <= 0)
            {
                Comp4Sombre.fillAmount = 0;
                isCooldown4 = false;
                Debug.Log("Comp4 prête");
            }
        }
    }
}

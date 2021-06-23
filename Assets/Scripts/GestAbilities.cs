using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GestAbilities : MonoBehaviour
{
    public float rotateVelocity;
    public GameObject Capsule;
    public CompQ Comp1 ;
    public CompW Comp2 ;
    public CompE Comp3 ;
    public CompR Comp4 ;

    [Header("Ability 1")]
    public Image abilityImage1;
    public float cooldown1 = 5;
    bool isCooldown = false;
    public KeyCode ability1;

    [Header("Ability 2")]
    public Image abilityImage2;
    public float cooldown2 = 10;
    bool isCooldown2 = false;
    public KeyCode ability2;

    [Header("Ability 3")]
    public Image abilityImage3;
    public float cooldown3 = 7;
    bool isCooldown3 = false;
    public KeyCode ability3;

    [Header("Ability 4")]
    public Image abilityImage4;
    public float cooldown4 = 10;
    bool isCooldown4 = false;
    public KeyCode ability4;

    // Start is called before the first frame update
    void Start()
    {
        abilityImage1.fillAmount = 0;
        abilityImage2.fillAmount = 0;
        abilityImage3.fillAmount = 0;
        abilityImage4.fillAmount = 0;

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
        if (Input.GetKey(ability1) && isCooldown == false)
        {
            Comp1.Launch();
        }
    }

    void Ability2()
    {
        if (Input.GetKey(ability1) && isCooldown == false)
        {
            Comp2.Launch();
        }
    }

    void Ability3()
    {
        if (Input.GetKey(ability1) && isCooldown == false)
        {
            Comp3.Launch();
        }
    }

    void Ability4()
    {
        if (Input.GetKey(ability1) && isCooldown == false)
        {
            Comp4.Launch();
        }
    }
}

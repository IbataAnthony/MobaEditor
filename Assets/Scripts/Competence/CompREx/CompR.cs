using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CompR : MonoBehaviour
{

    public Image imageBase1;
    public Image imageSombre1;
    public Image imageBase2;
    public Image imageSombre2;
    public Image imageBase3;
    public Image imageSombre3;
    public Charac charac;
    public float set;
    private GestAbilities gestAbilities;
    private bool stasis;
    public float stasisDuration = 2000;
    public Material stasisMat;
    public Material baseMat;
    public GameObject player;
    public float tmpSpd = 0;
    private float tmpHp;

    // Start is called before the first frame update
    public void Start()
    {
        stasis = false;
        gestAbilities = player.GetComponent<GestAbilities>();
    }


    // Update is called once per frame
    public void Update()
    {
        if (stasis)
        {
            /*if (gestAbilities.Comp1Sombre.fillAmount <= 0)
            {
                noCd1 = true;
            }
            if (gestAbilities.Comp2Sombre.fillAmount <= 0)
            {
                noCd2 = true;
            }
            if (gestAbilities.Comp3Sombre.fillAmount <= 0)
            {
                noCd3 = true;
            }
            if (gestAbilities.isCooldown1 = false) gestAbilities.isCooldown1 = true;
            if (gestAbilities.isCooldown2 = false) gestAbilities.isCooldown2 = true;
            if (gestAbilities.isCooldown3 = false) gestAbilities.isCooldown3 = true;
            if (gestAbilities.Comp1Sombre.fillAmount <= 0)
            {
                noCd1 = true;
            }
            if (gestAbilities.Comp2Sombre.fillAmount <= 0)
            {
                noCd2 = true;
            }
            if (gestAbilities.Comp3Sombre.fillAmount <= 0)
            {
                noCd3 = true;
            }*/

            stasisDuration -= 1;

            if (player.GetComponent<Charac>().currentHp < tmpHp) player.GetComponent<Charac>().currentHp = tmpHp;


        }

        if (stasisDuration <= 0.0)
        {
            stasis = false;
            stasisDuration = 2000;
            player.GetComponent<MeshRenderer>().material = baseMat;
            player.GetComponent<Hero>().speed = tmpSpd;
            tmpSpd = 0;


            gestAbilities.castable1 = true;
            gestAbilities.castable2 = true;
            gestAbilities.castable3 = true;

                /*if (noCd1)
            {
                noCd1 = false;
                gestAbilities.isCooldown1 = false;
                gestAbilities.Comp1Sombre.fillAmount = 0f;
            }
            if (noCd2)
            {
                noCd1 = false;
                gestAbilities.isCooldown2 = false;
                gestAbilities.Comp2Sombre.fillAmount = 0f;
            }
            if (!stasis && noCd3)
            {
                noCd1 = false;
                gestAbilities.isCooldown3 = false;
                gestAbilities.Comp3Sombre.fillAmount = 0f;
            }*/
        }
    }


    public void Launch()
    {
        if (set == 1)
        {
            Launch1();
        }
        else if (set == 2)
        {
            Launch2();
        }
        else
        {
            Launch3();
        }
    }


    public void Launch1()
    {
        tmpSpd += player.GetComponent<Hero>().speed;
        player.GetComponent<Hero>().speed = 0;
        player.GetComponent<MeshRenderer>().material = stasisMat;
        stasis = true;
        gestAbilities.castable1 = false;
        gestAbilities.castable2 = false;
        gestAbilities.castable3 = false;
        tmpHp = player.GetComponent<Charac>().currentHp;

    }

    public void Launch2()
    {
        charac.setCurrentHp(charac.getMaxHp().ToString());
        Debug.Log("CompR2 lancée");
    }

    public void Launch3()
    {
        charac.setCurrentHp(charac.getMaxHp().ToString());
        Debug.Log("CompR3 lancée");
    }
}
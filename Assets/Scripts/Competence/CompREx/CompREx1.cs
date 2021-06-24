using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CompREx1 : CompR
{
    public Image imageBase;
    public Image imageSombre;
    public Charac charac;
    public float Cooldown = 0;
    public bool rage;

    // Start is called before the first frame update
    public new void Start()
    {
        
    }

    // Update is called once per frame
    public new void Update()
    {
        if (Cooldown > 0)
        {
            charac.addDamage("25");
            charac.addAtkSpd("2");
            charac.takeDamage(1f);
            if (charac.getCurrentHp() <= 0)
            {
                charac.setCurrentHp("1");
            }
        }
        if (Cooldown == 0 && rage)
        {
            charac.addDamage("-25");
            charac.addAtkSpd("0.5");
            rage = false;
        }
    }

    public new void Launch()
    {
        Debug.Log("CompRRage lancée");
        rage = true;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreationCharac : MonoBehaviour

{

    public static GameObject[] player;
    public static GameObject capsule;
    private Charac charac;
    private GestAbilities gestAbilities;
    // Start is called before the first frame update


    private void Start()
    {
        GameObject[] player = GameObject.FindGameObjectsWithTag("Player");
        GameObject capsule = player[0];
        Charac charac = capsule.GetComponent(typeof(Charac)) as Charac;
        GestAbilities gestAbilities = capsule.GetComponent(typeof(GestAbilities)) as GestAbilities;

    }
    public void setComps(CompQ compQ, CompW compW, CompE compE, CompR compR)
    {
        gestAbilities.Comp1 = compQ;
        gestAbilities.Comp2 = compW;
        gestAbilities.Comp3 = compE;
        gestAbilities.Comp4 = compR;
    }

    public void setCompQ(CompQ compQ)
    {
        gestAbilities.Comp1 = compQ;
    }
    public void setCompW(CompW compW)
    {
        gestAbilities.Comp2 = compW;
    }
    public void setCompE(CompE compE)
    {
        gestAbilities.Comp3 = compE;
    }
    public void setCompR(CompR compR)
    {
        gestAbilities.Comp4 = compR;
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreationCharac : MonoBehaviour
{
    public GameObject capsule;
    public Charac charac;
    public GestAbilities gestAbilities;
    // Start is called before the first frame update



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
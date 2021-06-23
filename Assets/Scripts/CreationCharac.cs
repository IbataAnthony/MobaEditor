using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreationCharac : MonoBehaviour
{
    public GameObject capsule;
    public Charac charac;
    public Competences comps;
    // Start is called before the first frame update
    


    public void setComps(CompQ compQ, CompW compW , CompE compE, CompR compR )
    {
        comps.compQ = compQ;
        comps.compW = compW;
        comps.compE = compE;
        comps.compR = compR;
    }
     
    public void setCompQ ( CompQ compQ )
    {
        comps.compQ = compQ;
    }
    public void setCompE(CompE compE)
    {
        comps.compE = compE;
    }
    public void setCompW(CompW compW)
    {
        comps.compW = compW;
    }
    public void setCompR(CompR compR)
    {
        comps.compR = compR;
    }
}

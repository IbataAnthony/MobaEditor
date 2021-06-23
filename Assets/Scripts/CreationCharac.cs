using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreationCharac : MonoBehaviour
{
    GameObject capsule;
    Charac charac;
    Competences comps;
    // Start is called before the first frame update
    void Start()
    {
        // Création de la capsule
        capsule = GameObject.CreatePrimitive(PrimitiveType.Capsule);
        capsule.transform.position = new Vector3(0, 0, 0);

        // assignation des composants et scripts

        capsule.AddComponent(typeof(Hero));
        capsule.AddComponent(typeof(HeroCombat));
        capsule.AddComponent(typeof(Rigidbody));
        capsule.AddComponent(typeof(MeshRenderer));
        comps = capsule.AddComponent(typeof(Competences)) as Competences;
        charac = capsule.AddComponent(typeof(Charac)) as Charac;
    }


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

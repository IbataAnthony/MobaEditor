using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompEHealth : CompE
{

    public Charac charac;
    // Start is called before the first frame update
    public new void Start()
    {
        
    }

    // Update is called once per frame
    public new void Update()
    {
        
    }

    public new void Launch()
    {
        charac.setCurrentHp(charac.getMaxHp().ToString());

    }
}

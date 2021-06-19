using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickOnMe : MonoBehaviour
{
    // Start is called before the first frame update
    public Charac attack;
    public Charac target;
    void Start()
    {
        
    }
    public void takeDamage(Charac attack , Charac target)
    {

        float mult;
        if (target.armor.GetValue() > 0) mult = 100 / (100 + target.armor.GetValue());
        else mult = 2 - 100 / (100 - target.armor.GetValue());
        target.currentHp -= attack.damage.GetValue() * mult;
    }
    void OnMouseDown ()
    {
        Debug.Log("clic sur " + this.gameObject.name);
        takeDamage(attack, target);
    }
}

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
    public void takeDamage(Charac attack, Charac target)
    {

        float mult;
        if (target.getArmor() > 0) mult = 100 / (100 + target.getArmor());
        else mult = 2 - 100 / (100 - target.getArmor());
        target.currentHp -= attack.getAttack() * mult;
    }
    void OnMouseDown()
    {
        Debug.Log("clic sur " + this.gameObject.name);
        takeDamage(attack, target);
    }
}
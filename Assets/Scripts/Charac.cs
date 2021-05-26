using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Charac : MonoBehaviour
{
    public Stat maxHp;
    public int currentHp;
    public Stat damage;
    public Stat armor;
    public Stat attackSpeed;

    public void takeDamage ( int damage)
    {

        int mult;
        if (this.armor.GetValue() > 0) mult = 100 / (100 + this.armor.GetValue());
        else mult = 2 - 100 / (100 - this.armor.GetValue());
        currentHp -= damage * mult ;
    }
        
    }

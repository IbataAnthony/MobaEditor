using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class changeCharac : MonoBehaviour
{

    private Charac characScript;
    public Text baseValue;
    public Text newValue;
    public enum CharacAModifier { maxHp, damage, armor, attackSpeed };
    public CharacAModifier charac;

    // Start is called before the first frame update
    void Start()
    {
        characScript = GameObject.FindGameObjectWithTag("Player").GetComponent<Charac>();
        //characScript = GameObject.FindGameObjectWithTag("Player").GetComponent<Charac>();
        //if ( CharacAModifier == maxHp ) 
        if (charac == CharacAModifier.damage) baseValue.text = characScript.getAttack().ToString();
        if (charac == CharacAModifier.armor) baseValue.text = characScript.getArmor().ToString();
        if (charac == CharacAModifier.attackSpeed) baseValue.text = characScript.getAttackSpeed().ToString();
        else baseValue.text = characScript.getMaxHp().ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if (newValue.text != "")
        {
            if (charac == CharacAModifier.damage) characScript.setDamage(newValue.text);
            if (charac == CharacAModifier.armor) characScript.setArmor(newValue.text);
            if (charac == CharacAModifier.attackSpeed) characScript.setAttackSpeed(newValue.text);
            else characScript.setMaxHp(newValue.text);
        }
        else
        {
            if (charac == CharacAModifier.damage) characScript.setDamage(baseValue.text);
            if (charac == CharacAModifier.armor) characScript.setArmor(baseValue.text);
            if (charac == CharacAModifier.attackSpeed) characScript.setAttackSpeed(baseValue.text);
            else characScript.setMaxHp(baseValue.text);
        }
    }
}
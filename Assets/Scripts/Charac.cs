using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Charac : MonoBehaviour
{
    UiStat_inGame UiStat_inGame;

    public bool dead = false;
    public float timer = 0.0f;
    public float cooldown = 2.0f;
    public GameObject respPoint;
    private Rigidbody body;
    public float maxHp = 100;
    public float armor = 5;
    public float damage = 10;
    //HPTot et currentHP sont des entiers bruts qu'il faudra remplacer par leurs stats correspondantes
    public float HPTot;
    public float currentHp;
    
    public float attackSpeed;

    void Start()
    {
        UiStat_inGame = GetComponent<UiStat_inGame>();
   currentHp = maxHp;
        DisplayStat();
    }

    //Update() is called once per frame
    void Update()
    {
        if (currentHp <= 0)
        {
            //no more health
            this.dead = true;
            death();
        }
    }


    void DisplayStat() {
        UiStat_inGame.Attack.text = damage.ToString();
        UiStat_inGame.Armor.text = armor.ToString();

    }

    public float getArmor()
    {
        return armor;
    }
    public float getAttack()
    {
        return damage;
    }
    
    public void setArmor(string a)
    {                                 
        armor = float.Parse(a);
    }

    public void setMaxHp(string a)
    {
        maxHp = float.Parse(a);
    }


    public void setDamage(string a)
    {                                         
        damage = float.Parse(a);
    }

    public void suicide()
    {
        this.currentHp -= 20;
    }

    public void takeDamage(float damage)
    {
        float mult;
        if (this.getArmor() > 0) mult = 100 / (100 + this.getArmor());
        else mult = 2 - 100 / (100 - this.getArmor());
        currentHp -= damage * mult;
       
        //rectification de la barre de HP
        //float _h = Mathf.Clamp(currentHp, 0.0f, HPTot);
        //healthBar.value = _h;
        
    }

    private void death()
    {

        if (dead == true)
        {

            //si l'entit�Emeurt, le timer s'enclenche
            timer += Time.deltaTime;
        }

       
        if (timer >= cooldown)
        {
            //Si le timer arrive �Eterme, l'entit�Erespawn
            timer = 0;
            respawn();
        }

    }

    private void respawn()
    {
        dead = false;
        this.transform.position = respPoint.transform.position;
        currentHp = HPTot;
 
    }
}

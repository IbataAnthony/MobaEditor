using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Charac : MonoBehaviour
{
    public bool dead = false;
    public float timer = 0.0f;
    public float cooldown = 2.0f;
    public GameObject respPoint;
    private Rigidbody body;
    public Stat maxHp;
    //HPTot et currentHP sont des entiers bruts qu'il faudra remplacer par leurs stats correspondantes
    public int HPTot;
    public int currentHp;
    public Stat damage;
    public Stat armor;
    public Stat attackSpeed;

    void Start()
    {
        currentHp = maxHp.GetValue();
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

    public void suicide()
    {
        this.currentHp = 0;
    }

    public void takeDamage(int damage)
    {
        int mult;
        if (this.armor.GetValue() > 0) mult = 100 / (100 + this.armor.GetValue());
        else mult = 2 - 100 / (100 - this.armor.GetValue());
        currentHp -= damage * mult;
       
        //rectification de la barre de HP
        //float _h = Mathf.Clamp(currentHp, 0.0f, HPTot);
        //healthBar.value = _h;
        
    }

    private void death()
    {

        if (dead == true)
        {

            //si l'entité meurt, le timer s'enclenche
            timer += Time.deltaTime;
        }

       
        if (timer >= cooldown)
        {
            //Si le timer arrive à terme, l'entité respawn
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

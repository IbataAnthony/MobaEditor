using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.UI;


public class HealthBar : MonoBehaviour
{
    public Slider healthBar;
    public Color Low;
    public Color High;
    public Vector3 Offset;
    private int currentHP = 100;
       
    // Start is called before the first frame update
    void Start()
    {
        healthBar = GetComponent<Slider>();
    }

    // Update is called once per frame
    void Update()
    {
        healthBar.value = currentHP;
    }

    // Appelée lors d'un soin ou de dégâts. Change la valeur des HPs actuels, à modifier après la création des stats HP et HPMax
    public void changeHP(int dHP)
    {
        currentHP += dHP;
    }

    // Initialise la barre de HP
    public void SetHealth(float health, float maxHealth)
    {
        healthBar.gameObject.SetActive(health < maxHealth);
        healthBar.value = health;
        healthBar.maxValue = maxHealth;
        healthBar.fillRect.GetComponentInChildren<Image>().color = Color.Lerp(Low, High, healthBar.normalizedValue);
    }
}

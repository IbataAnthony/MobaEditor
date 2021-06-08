using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class HealthBar : MonoBehaviour
{
    private Slider healthBar;
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

    public void changeHP(int dHP)
    {
        currentHP += dHP;
    }
}

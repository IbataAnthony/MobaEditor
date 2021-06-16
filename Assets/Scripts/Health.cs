using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{

    public Slider playerSlider3D;
    Slider playerSlider2D;

    Charac statsScript;

    // Start is called before the first frame update
    void Start()
    {
        statsScript = GameObject.FindGameObjectWithTag("Player").GetComponent<Charac>();

        playerSlider2D = GetComponent<Slider>();

        playerSlider3D.maxValue = statsScript.maxHp.GetValue();
        playerSlider2D.maxValue = statsScript.maxHp.GetValue();
        statsScript.currentHp = statsScript.maxHp.GetValue();
    }

    // Update is called once per frame
    void Update()
    {

        playerSlider2D.value = statsScript.currentHp;
        playerSlider3D.value = playerSlider2D.value;

    }
}
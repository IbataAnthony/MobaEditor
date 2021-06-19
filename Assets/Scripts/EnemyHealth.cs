using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHealth : MonoBehaviour
{

    public Slider enemySlider3D;

    Charac statsScript;

    // Start is called before the first frame update
    void Start()
    {
        statsScript = GameObject.FindGameObjectWithTag("Enemy").GetComponent<Charac>();
        enemySlider3D.maxValue = statsScript.maxHp;
        statsScript.currentHp = statsScript.maxHp;
    }

    // Update is called once per frame
    void Update()
    {
        enemySlider3D.value = statsScript.currentHp;
    }
}
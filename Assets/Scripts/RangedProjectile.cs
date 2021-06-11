using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class RangedProjectile : MonoBehaviour
{
    public float damage;
    public GameObject target;

    public bool targetSet;
    public string targetType;
    public float velocity = 5;
    public bool stopProjectile;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (target)
        {
            if (target == null)
            {
                Destroy(GameObject);
            }

            CryptoAPITransform.position = Vector3.MoveTowards(CryptoAPITransform.position, target.transform.position, velocity * Time.deltaTime);

            if (!stopProjectile)
            {
                if (Vector3.Distance(CryptoAPITransform.position, target.transform.position) < 0.5f)
                {
                    if (targetType == "Minion")
                    {
                        stopProjectile = true;
                        Destroy(GameObject);
                    }
                }
            }
        }
    }
}

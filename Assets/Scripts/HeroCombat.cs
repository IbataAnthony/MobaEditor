using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroCombat : MonoBehaviour
{

    public enum HeroAttackType { Melee, Ranged };
    public HeroAttackType heroAttackType;

    public GameObject targetedEnemy;
    public float attackRange;
    public float rotateSpeedForAttack;

    private Movement moveScript;
    private Charac statsScript;
    //private Animator anim;

    public bool basicAtkIdle = false;
    public bool isHeroAlive;
    public bool performMeleeAttack = true;

    // Start is called before the first frame update
    void Start()
    {
        moveScript = GetComponent<Movement>();
        statsScript = GetComponent<Charac>();
        //anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (targetedEnemy != null)
        {
            if (Vector3.Distance(gameObject.transform.position, targetedEnemy.transform.position) > attackRange)
            {
                moveScript.agent.SetDestination(targetedEnemy.transform.position);
                moveScript.agent.stoppingDistance = attackRange;

                //Rotation
                Quaternion rotationToLookAt = Quaternion.LookRotation(targetedEnemy.transform.position - transform.position);
                float rotationY = Mathf.SmoothDampAngle(transform.eulerAngles.y, rotationToLookAt.eulerAngles.y, ref moveScript.rotateVelocity, rotateSpeedForAttack * (Time.deltaTime * 5));

                transform.eulerAngles = new Vector3(0, rotationY, 0);
            }
            else
            {
                if (heroAttackType == HeroAttackType.Melee)
                {
                    if (performMeleeAttack)
                    {
                        Debug.Log("Attack the Minion");

                        StartCoroutine(MeleeAttackInterval());
                    }
                }
            }
        }
    }

    IEnumerator MeleeAttackInterval()
    {
        performMeleeAttack = false;
        //anim.SetBool("Basic Attack", true);

        yield return new WaitForSeconds(statsScript.attackSpeed / ((100.0f + statsScript.attackSpeed) * 0.01f));

        if (targetedEnemy == null)
        {
            //anime.SetBool("Basic Attack, false);

            performMeleeAttack = true;
        }
    }

    public void MeleeAttack()
    {
        if (targetedEnemy != null)
        {
            if (targetedEnemy.GetComponent<Targetable>().enemyType == Targetable.EnemyType.Minion)
            {
                targetedEnemy.GetComponent<Charac>().currentHp -= statsScript.damage;
            }
        }

        performMeleeAttack = true;
    }
}
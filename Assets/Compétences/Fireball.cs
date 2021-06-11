using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Reflection;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;

public class Fireball : MonoBehaviour
{

    [Header("Fireball Ability")]
    public Image fireBallImage;
    public float cooldown = 10;
    bool isCooldown = false;
    bool canFireball = true;
    public KeyCode ability1;
    public GameObject projPrefab;
    public Transform projSpawnPoint;

    //Ability Input Variables
    [Header("Fireball Ability Inputs")]
    public ImageFileMachine indicatorRangeCircle;
    public float maxAbilityDistance;

    [SerializeField]
    public GameObject targetedEnemy;



    // Start is called before the first frame update
    void Start()
    {
        fireBallImage.fillAmount = 0;
        indicatorRangeCircle.GetComponent<Image>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        FireballAbility();
    }

    void FireballAbility()
    {
        if (Input.GetKey(ability1) && isCooldown = false)
        {
            indicatorRangeCircle.GetComponent<Image>().enabled = true;
        }

        if (indicatorRangeCircle.GetComponent<Image>().enabled)
        {
            if (Input.GetMouseButtonDown(0))
            {
                if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, Mathf.Infinity))
                {
                    if (hit.collider.GetComponent<Targetable>() != null &&
                        hit.collider.gameObject.GetComponent<Targetable>().ennemyType == Targetable.EnemyType.Minion)
                    {
                        targetedEnemy = hit.collider.gameObject;
                    }
                    else if (hit.collider.GetComponent<Targetable>() == null)
                    {
                        targetedEnemy = null;
                    }
                }
            }
            else if (Input.GetMouseButtonDown(1))
            {
                targetedEnemy = null;
            }
        }

        if (targetedEnemy != null)
        {
            if (Vector3.Distance(gameObject.transform.position, targetedEnemy.transform.position) >= maxAbilityDistance)
            {
                targetedEnemy = null;
            }
            else
            {
                if (canFireball)
                {
                    isCooldown = true;
                    fireBallImage.fillAmount = 1;
                    FireBallAttack();
                    StartCoroutine(Fireball());
                }
            }
        }

        if (isCooldown)
        {
            fireBallImage.fillAmount -= 1 / cooldown * Time.deltaTime;

            indicatorRangeCircle.GetComponent<Image>().enabled = false;

            if (fireBallImage.fillAmount <= 0)
            {
                fireBallImage.fillAmount = 0;
                isCooldown = false;
            }
        }
    }

    IEnumerator FireBall()
    {
        canFireball = false;
        anim.SetBool("Fireball", true);

        yield return new WaitForSeconds(1.5f);

        if (targetedEnemy == null)
        {
            anim.SetBool("Fireball", false);
            canFireball = true;
        }
    }

    public void FireBallAttack()
    {
        if (targetedEnemy != null)
        {
            if (targetedEnemy.GetComponent<Targetable>().enemyType == Targetable.EnemyType.Minion)
            {
                SpawnRangedProj("Minion", targetedEnemy);
            }
        }

        targetedEnemy = null;
        canFireball = true;
    }

    void SpawnRangedProj(string typeOfEnemy, GameObject targetedEnemyObj)
    {
        Instantiate(projPrefab, projSpawnPoint.transform.position, Quaternion.identity());

        if (typerOfEnemy == "Minion")
        {
            prjPrefab.GetComponent<RangedProjectile>().target = targetedEnemyObj;
            prjPrefab.GetComponent<RangedProjectile>().targetSet = true;
        }
    }
}

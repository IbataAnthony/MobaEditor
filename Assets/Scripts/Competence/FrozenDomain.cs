using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FrozenDomain : MonoBehaviour
{

    //In Script Stuff
    Animator anim;
    RaycastHit hit;
    Movement moveScript;
    Charac statScript;

    [Header("Frozen Domain Ability")]
    public Image frozenDomainImage;
    public float cooldown = 10;
    bool isCooldown4 = false;
    public KeyCode ability4;
    bool canFireball = true;
    public GameObject projPrefab;
    public Transform projSpawnPoint;

    //Ability Input Variables
    [Header("Frozen Domain Ability Inputs")]
    public Image indicatorRangeCircle;
    public Image targetCircle;
    public float maxAbilityDistance;
    public Vector3 playerPosition;
    public Vector3 minPosition;
    public Vector3 maxPosition;
    public Abilities abilities;

    bool isIn = true;

    [SerializeField]
    public GameObject targetedEnemy;


    // Start is called before the first frame update
    void Start()
    {
        frozenDomainImage.fillAmount = 0;

        indicatorRangeCircle.GetComponent<Image>().enabled = false;

        moveScript = GetComponent<Movement>();
        anim = GetComponent<Animator>();

        playerPosition = GameObject.FindGameObjectWithTag("Player").transform.position;
        minPosition = new Vector3(0, 50f, -50f);
        maxPosition = new Vector3(80f, 50f, -50f);
    }

    // Update is called once per frame
    void Update()
    {
        FrozenDomainAbility();


    }

    void FrozenDomainAbility()
    {
        //Enable the Circle and Cursor
        if (Input.GetKey(ability4) && isCooldown4 == false)
        {
            indicatorRangeCircle.GetComponent<Image>().enabled = true;
        }

        //Click on the Enemy
        if (indicatorRangeCircle.GetComponent<Image>().enabled == true)
        {
            if (Input.GetMouseButtonDown(0))
            {
                if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, Mathf.Infinity))
                {
                    //if (hit.collider.tag == "Floor")
                    //{
                    frozenDomainImage.enabled = true;


                    //}
                }
            }
        }
        else if (Input.GetMouseButtonDown(1))
        {
            targetedEnemy = null;
            indicatorRangeCircle.GetComponent<Image>().enabled = false;
        }


        //Move Towards the Enemy and Shoot Fireball

        if (Vector3.Distance(gameObject.transform.position, hit.point) >= maxAbilityDistance)
        {
            moveScript.agent.SetDestination(hit.point);
            moveScript.agent.stoppingDistance = maxAbilityDistance - 0.5f;
        }
        else
        {
            //ROTATE
            Quaternion rotationToLookAt = Quaternion.LookRotation(hit.point - transform.position);
            float rotationY = Mathf.SmoothDampAngle(transform.eulerAngles.y,
                rotationToLookAt.eulerAngles.y,
                ref moveScript.rotateVelocity,
                0.075f * (Time.deltaTime * 5));

            transform.eulerAngles = new Vector3(0, rotationY, 0);

            moveScript.agent.SetDestination(transform.position);
            moveScript.agent.stoppingDistance = 0;


            //Spawn Fireball
            if (canFireball)
            {
                isCooldown4 = true;
                frozenDomainImage.fillAmount = 1;


                StartCoroutine(AreaOfEffect());
            }
        }

        //Ability goes to Cooldown
        if (isCooldown4)
        {
            frozenDomainImage.fillAmount -= 1 / cooldown * Time.deltaTime;

            indicatorRangeCircle.GetComponent<Image>().enabled = false;

            if (frozenDomainImage.fillAmount <= 0)
            {
                frozenDomainImage.fillAmount = 0;
                isCooldown4 = false;
            }
        }

    }

    IEnumerator AreaOfEffect()
    {
        canFireball = false;
        isIn = true;
        //anim.SetBool("Fireball", true);

        yield return new WaitForSeconds(1.5f);



        if (targetedEnemy == null)
        {
            //anim.SetBool("Fireball", false);
            canFireball = true;
            frozenDomainImage.fillAmount -= 1 / cooldown * Time.deltaTime;

            indicatorRangeCircle.GetComponent<Image>().enabled = false;
            targetCircle.GetComponent<Image>().enabled = false;

            if (frozenDomainImage.fillAmount <= 0)
            {
                frozenDomainImage.fillAmount = 0;
                isCooldown4 = false;
            }
        }

        if (abilities.frozenDomainActive)
        {
            for (int i = 0; i < 3 && isIn; ++i)
            {
                if (playerPosition[i] < minPosition[i] || playerPosition[i] > maxPosition[i])
                    isIn = false;
            }

            if (isIn)
            {
                statScript.attackSpeed += 0.2f;
                Debug.Log("The player is inside the area");
            }
        }
    }

    public void FireBallAttack()
    {
        if (targetedEnemy != null)
        {
            /*if (targetedEnemy.GetComponent<Targetable>().enemyType == Targetable.EnemyType.Minion)
            {
                SpawnRangedProj("Minion", targetedEnemy);
            }*/
        }

        targetedEnemy = null;
        canFireball = true;
    }

    void SpawnRangedProj(string typeOfEnemy, GameObject targetedEnemyObj)
    {
        // Instantiate(projPrefab, projSpawnPoint.transform.position, Quaternion.identity);

        if (typeOfEnemy == "Minion")
        {
            projPrefab.GetComponent<RangedProjectile>().targetType = typeOfEnemy;

            projPrefab.GetComponent<RangedProjectile>().target = targetedEnemyObj;
            projPrefab.GetComponent<RangedProjectile>().targetSet = true;
        }
    }
}

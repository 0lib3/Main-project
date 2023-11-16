using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

public class enemyAI : MonoBehaviour
{
    private Transform playerPosition;
    [SerializeField] float moveSpeed;
    [SerializeField] float aRange;
    [SerializeField] float armedDistance;
    private bool isArmed = false;
    public static UnityEvent<float> takeDmg = new UnityEvent<float>();

    private void Awake()
    {
    }

    private void Start()
    {
        playerPosition = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    private void Update()
    {
        if(Vector2.Distance(transform.position, playerPosition.position) <= aRange)
        {
            Vector2 directionToPlayer = (playerPosition.position - transform.position).normalized;
            //Vector2.MoveTowards(transform.position, playerPosition.position, moveSpeed * Time.deltaTime);
            transform.Translate(directionToPlayer * moveSpeed * Time.deltaTime);
        }

        if(isArmed == false && Vector2.Distance(transform.position, playerPosition.position) <= armedDistance) 
        {
            StartCoroutine(bombArm());
        }
    }

    IEnumerator bombArm()
    {
        isArmed = true;
        yield return new WaitForSeconds(3);
        blowUp();
    }

    private void blowUp()
    {
        takeDmg.Invoke(.3f);
        Destroy(gameObject);
    }
}

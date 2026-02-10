using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float moveSpeed = 2f;
    public float chaseDistance = 5f;
    public float attackDistance = 1f;
    public Transform player;

    private Vector2 direction;
    private bool isChasing = false;

    void Update()
    {
        float distanceToPlayer = Vector2.Distance(transform.position, player.position);

        if (distanceToPlayer < chaseDistance)
        {
            isChasing = true;
        }
        else
        {
            isChasing = false;
        }

        if (isChasing)
        {
            ChasePlayer();
            if (distanceToPlayer < attackDistance)
            {
                AttackPlayer();
            }
        }
    }

    void ChasePlayer()
    {
        direction = (player.position - transform.position).normalized;
        transform.position = Vector2.MoveTowards(transform.position, player.position, moveSpeed * Time.deltaTime);
    }

    void AttackPlayer()
    {
        // Attacking logic here (e.g., deal damage to player)
        Debug.Log("Enemy attacks the player!");
    }
}
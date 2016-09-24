using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {
    public Transform target;
    private int health, damage;
    private float speed;
    private string enemyType;
    private NavMeshAgent agent;
    public Enemy()
    {
        switch(enemyType)
        {
            case "Chicken Bandit":
                health = 100;
                damage = 1;
                speed = 20;
                break;
            case "Chicken Overlord":
                health = 1000;
                speed = 5f;
                damage = 50;
                break;
            case "Robot Chicken":
                health = 175;
                speed = 155f;
                damage = 5;
                break;
            default:
                health = 100;
                damage = 1;
                speed = 20;
                break;

        }
    }
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.speed = speed;
        target = GameObject.Find("EnemyGoal").transform;
    }
    void Update()
    {
        agent.SetDestination(target.position);
        if (!agent.pathPending)
        {
            if (agent.remainingDistance <= agent.stoppingDistance)
            {
                if (!agent.hasPath || agent.velocity.sqrMagnitude == 0f)
                {
                    Destroy(gameObject);
                }
            }
        }
    }
}

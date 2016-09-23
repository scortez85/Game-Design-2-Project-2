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
                speed = 3;
                break;
            case "Chicken Overlord":
                health = 1000;
                speed = 0.5f;
                damage = 100;
                break;
            case "Robot Chicken":
                health = 175;
                speed = 15.5f;
                damage = 10;
                break;
        }
    }
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }
    void Update()
    {
        agent.SetDestination(target.position);
    }
}

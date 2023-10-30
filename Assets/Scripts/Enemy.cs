using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    [SerializeField] private Transform Player;
    [SerializeField] private NavMeshAgent agent;
    [SerializeField] private float initialDelay;
    [SerializeField] private float findPlayerRate;
    public int maxEnemy = 25;
    [SerializeField] Screen Win;


    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();

        InvokeRepeating("FindPlayer", initialDelay, findPlayerRate);
    }

    // Update is called once per frame
    void Update()
    {
        if (maxEnemy == 0)
        {
            
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            maxEnemy--;
            Destroy(this.gameObject);
            
        } 
    }

    private void FindPlayer()
    {
        agent.destination = Player.position;
    }
}

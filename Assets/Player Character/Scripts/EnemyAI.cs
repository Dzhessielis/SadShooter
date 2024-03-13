using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour
{
    public List<Transform> patrolPoints;
    private NavMeshAgent _navMeshAgent;
    // Start is called before the first frame update
    void Start()
    {
        _navMeshAgent = GetComponent<NavMeshAgent>();

       // Random.Range(patrolPoints);

    }

    // Update is called once per frame
    void Update()
    {
       // _navMeshAgent.destination = targetPoint.position;
    }
}

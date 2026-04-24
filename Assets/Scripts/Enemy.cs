using StarterAssets;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    NavMeshAgent agent;
    FirstPersonController player;
    //[SerializeField] Transform target;

    void Awake()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    void Start()
    {
        player = FindFirstObjectByType<FirstPersonController>();
        //agent.SetDestination(target.position);
        
    }

    // Update is called once per frame
    void Update()
    {
        agent.SetDestination(player.transform.position);
    }
}

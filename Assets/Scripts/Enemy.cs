using StarterAssets;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
   NavMeshAgent Agent;
    [SerializeField] Transform target;
    [SerializeField] FirstPersonController player;
    

    private void Awake()
    {
        Agent = GetComponent<NavMeshAgent>();




    }
    void Start()
    {
        //Agent.SetDestination(target.position);
       player = FindAnyObjectByType<FirstPersonController>();
    }

    // Update is called once per frame
    void Update()
    {
        Agent.SetDestination(player.transform.position);

    }
}

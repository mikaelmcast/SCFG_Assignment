using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AIControl : MonoBehaviour
{
    GameObject[] pointLocations;
    NavMeshAgent agent;
    Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        agent = this.GetComponent<NavMeshAgent>();
        pointLocations = GameObject.FindGameObjectsWithTag("waypoint");
        int i = Random.Range(0, pointLocations.Length);
        agent.SetDestination(pointLocations[i].transform.position);
        anim = this.GetComponent<Animator>();
        anim.SetTrigger("isWalking");
    }

    // Update is called once per frame
    void Update()
    {
        if (agent.remainingDistance < 1)
        {
            int i = Random.Range(0, pointLocations.Length);
            agent.SetDestination(pointLocations[i].transform.position);
        }
    }
}
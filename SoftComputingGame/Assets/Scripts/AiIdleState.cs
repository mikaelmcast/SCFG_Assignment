using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AiIdleState : AIState
{
    public void Enter(AIAgent agent)
    {

    }

    public void Exit(AIAgent agent)
    {

    }

    public AiStateId GetId()
    {
        return AiStateId.Walking;
    }

    public void Update(AIAgent agent)
    {
        Vector3 playerDirection = agent.playerTransform.position - agent.transform.position;
        if (playerDirection.magnitude > agent.config.maxSightDistance)
        {
            return;
        }

        Vector3 agentDirection = agent.transform.forward;

        playerDirection.Normalize();

        float dorProduct = Vector3.Dot(playerDirection, agentDirection);
        if (dorProduct > 0.0f)
        {
            agent.stateMachine.ChangeState(AiStateId.ChasePlayer);
        }
    }
}
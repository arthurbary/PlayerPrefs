using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
[RequireComponent(typeof(NavMeshAgent))]
public class PlayerMovement : MonoBehaviour
{
    private NavMeshAgent agent;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        MoveOnClick();
    }

    private void MoveOnClick()
    {
        if(Input.GetMouseButton(0)){
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Debug.DrawRay(ray.origin, ray.direction*100, Color.green);
            RaycastHit hit;
            if(Physics.Raycast(ray,out hit))
            {
                agent.SetDestination(hit.point);
                PlayerData.destination = hit.point;
                PlayerData.position = gameObject.transform.position;
            }
            Debug.Log(PlayerData.destination);
            Debug.Log(PlayerData.position);
        }

    }
}

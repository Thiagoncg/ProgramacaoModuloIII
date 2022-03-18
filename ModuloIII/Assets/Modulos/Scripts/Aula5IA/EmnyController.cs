using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EmnyController : MonoBehaviour
{
    public Camera cam;
    public NavMeshAgent agent;
    public Transform MovePlayer;
    void Awake() 
    {
        agent = GetComponent<NavMeshAgent>();
    }
    void Update()
    {
        //ClickLocalization();
        EnemyFollowPlayer();
    }
    private void ClickLocalization()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                //Move player
                agent.SetDestination(hit.point);
            }
        }
    }
    private void EnemyFollowPlayer()
    {
        agent.destination = MovePlayer.position;
    }
}

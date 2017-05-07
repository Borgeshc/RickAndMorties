using UnityEngine;
using System.Collections;

public class AIMovement : MonoBehaviour
{
    public float speed;
    public bool cantMove;

    NavMeshAgent agent;

    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        Destroy(gameObject, 50);
    }

    void Update ()
    {
        if(!cantMove)
        agent.SetDestination(transform.forward * 100 * speed * Time.deltaTime);
	}
}

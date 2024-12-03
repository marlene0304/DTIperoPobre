using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class IA : MonoBehaviour
{
    //La IA
    public NavMeshAgent agent;
    //A donde queremos que se mueva
    public GameObject[] target;

    public GameObject player;
    public int nextTarget;
    public bool followingPlayer;
    RaycastHit hit;
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        if(followingPlayer == true)
        {
            agent.destination = player.transform.position;
        }
        else
        {
            agent.destination = target[nextTarget].transform.position;
        }
        

        Debug.DrawRay(transform.position, Vector3.forward * 5, Color.red);
        if (Physics.Raycast(transform.position, Vector3.forward, out hit, 5))
        {
            print(hit.transform.name);
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        if(other.transform.tag == "obj")
        {
            Debug.Log("Aqui");
            nextTarget++;
            if(nextTarget >= target.Length)
            {
                nextTarget = 0;
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "Player")
        {
            followingPlayer = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.transform.tag == "Player")
        {
            followingPlayer = false;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy_follow : MonoBehaviour
{

    public NavMeshAgent enemy;
    public GameObject Life;

    // Start is called before the first frame update
    void Start()
    {
        Life = GameObject.Find("Oskour");
    }

    // Update is called once per frame
    void Update()
    {
        enemy.SetDestination(Life.transform.position);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    [SerializeField] private float Force;
    [SerializeField] private Rigidbody EnemyKiller;
    [SerializeField] private Transform Tip;

    // Start is called before the first frame update
    void Start()
    {
         
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Rigidbody rigidbody = Instantiate(EnemyKiller, Tip.position, Quaternion.identity);
            rigidbody.AddForce(Tip.forward * Force, ForceMode.Impulse);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField]
    private GameObject Prefab;

    [SerializeField]
    private float Rate;

    [SerializeField]
    private float Width;

    private float LastSpawn;

    // Start is called before the first frame update
    void Start()
    {
        LastSpawn = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if((Time.time - LastSpawn) >= (1f/Rate))
        {
            LastSpawn = Time.time;
            Spawn();
        }
    }

    void Spawn()
    {
        var position = new Vector2(Random.Range(Width * -0.5f, Width * 0.5f), transform.position.y);
        Instantiate(Prefab, position, transform.rotation);
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawLine(transform.position - new Vector3(Width * 0.5f,0,0), transform.position + new Vector3(Width * 0.5f ,0,0));
    }
}

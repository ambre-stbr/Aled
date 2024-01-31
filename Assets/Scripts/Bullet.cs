using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }
    void Awake()
    {
        StartCoroutine(DestroySelf(2));
    }

    IEnumerator DestroySelf(float DestroyTime)
    {
        yield return new WaitForSeconds(DestroyTime);
        Destroy(gameObject);
    }

}

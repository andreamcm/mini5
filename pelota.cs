using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pelota : MonoBehaviour
{
    public GameObject pelotita;
    public Rigidbody rb;
    float thrust = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "persona")
        {
            rb.AddForce(transform.forward * thrust);
        }

        if (collision.gameObject.tag == "porteria")
        {
            Destroy(gameObject);
        }
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tree : MonoBehaviour
{
    public Rigidbody treeRigidbody = default;
    public float speed = 50.0f;

    // Start is called before the first frame update
    void Start()
    {
        treeRigidbody.velocity = transform.forward * (-speed);

        Destroy(gameObject, 2.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

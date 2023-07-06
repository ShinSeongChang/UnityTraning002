using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    private Rigidbody attackRigidbody = default;
    public float speed = 10.0f;

    // Start is called before the first frame update
    void Start()
    {
        attackRigidbody = GetComponent<Rigidbody>();
        attackRigidbody.velocity = transform.forward * (-speed);
        Destroy(gameObject, 3f);
        //attackRigidbody.velocity = new Vector3(0,0,-1) * speed;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Enemy")
        {
            Destroy(this.gameObject);
        }
    }
}

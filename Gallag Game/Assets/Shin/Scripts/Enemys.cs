using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemys : MonoBehaviour
{
    private Rigidbody enemyRigidbody = default;
    public GameObject explosions = default;
    private float speed = 15.0f;

    // Start is called before the first frame update
    void Start()
    {
        enemyRigidbody = GetComponent<Rigidbody>();
        enemyRigidbody.velocity = transform.forward * speed;        
    }

    // Update is called once per frame
    void Update()
    {

    }

    //public void OnTriggerEnter(Collider other)
    //{
    //    if (other.tag == "Player")
    //    {
    //        Destroy(this.gameObject);
    //    }
    //    else if (other.tag == "Wall")
    //    {
    //        Destroy(this.gameObject);
    //    }
    //    else if (other.tag == "Attack")
    //    {
    //        Destroy(this.gameObject);
    //    }
    //}

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Player")
        {
            Destroy(this.gameObject);
        }
        else if(collision.collider.tag == "Wall")
        {
            Destroy(this.gameObject);
        }
        else if(collision.collider.tag == "Attack")
        {
            Instantiate(explosions, transform.position, transform.rotation);    
            enemyRigidbody.AddForce(0f, 500f, -1000f);
            Destroy(this.gameObject, 1.5f);
        }
        //else if(collision.collider.tag == "Enemy")
        //{
        //    enemyRigidbody.AddForce(0f, 500f, -1000f);
        //    Destroy(this.gameObject, 1.5f);
        //}

    }
}

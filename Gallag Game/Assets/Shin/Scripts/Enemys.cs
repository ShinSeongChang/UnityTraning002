using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemys : MonoBehaviour
{
    private Rigidbody enemyRigidbody = default;
    public float speed = 7.0f;

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

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Destroy(this.gameObject);          
            MoveCar player = GetComponent<MoveCar>();

        }
        else if (other.tag == "Wall")
        {
            Destroy(this.gameObject);
        }
        else if(other.tag == "Attack")
        {
            Destroy(this.gameObject);
        }
    }

}

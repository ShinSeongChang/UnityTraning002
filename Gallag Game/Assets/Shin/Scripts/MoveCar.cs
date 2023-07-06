using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCar : MonoBehaviour
{
    private Rigidbody playerRigidbody = default;
    public float speed = 15.0f;
    private int life_Count = 4;

    // Start is called before the first frame update
    void Start()
    {
        playerRigidbody = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float zInput = Input.GetAxis("Vertical");
        float xInput = Input.GetAxis("Horizontal");

        float zSpeed = zInput * speed;
        float xSpeed = xInput * speed;

        Vector3 playerVector = new Vector3(xSpeed, 0f, zSpeed);
        playerRigidbody.velocity = playerVector;
    }

    public void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Enemy")
        {
            life_Count--;

            if(life_Count == 0)
            {
                gameObject.SetActive(false);
            }
        }
    }

}

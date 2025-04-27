using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{

     private Rigidbody2D rb; //link to the component
     private float health;


    // Start is called before the first frame update
    
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        health = 100f;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector2.up * 250f);
        }

        transform.eulerAngles = new Vector3(0, 0, rb.velocity.y);
        health -= Time.deltaTime;
    }


     private void OnTriggerEnter2D(Collider2D other)
    {
        // Debug.Log(other.tag);

        if(other.CompareTag("food"))
        {
            Destroy(other.gameObject);
            health = Mathf.Clamp(health + 10f, 0f, 100f); //health + max 50, more than 0, less than 100
        }

        if(other.CompareTag("banana"))
        {
            Destroy(other.gameObject);
            health = Mathf.Clamp(health + 5f, 10f, 100f); //health + max 50, more than 0, less than 100
        }

        Debug.Log(health);
    }
}

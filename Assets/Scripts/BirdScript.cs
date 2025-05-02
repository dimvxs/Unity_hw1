using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BirdScript : MonoBehaviour
{

     private Rigidbody2D rb; //link to the component
     public static float health;
     private float healthTimeout = 30.0f; //in seconds
     private int tries;

     [SerializeField]
     private TMPro.TextMeshProUGUI triesTmp;


    // Start is called before the first frame update
    
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        health = 1.0f;
        tries = 3;
        triesTmp.text = tries.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector2.up * 250f * Time.timeScale * Vector2.up);
        }

        transform.eulerAngles = new Vector3(0, 0, rb.velocity.y);
        health -= Time.deltaTime /healthTimeout;
        if(health <= 0)
        {
            Loose();
        }
    }


     private void OnTriggerEnter2D(Collider2D other)
    {
         Debug.Log(other.tag);

        if(other.CompareTag("food"))
        {
            Destroy(other.gameObject);
            // health = Mathf.Clamp(health + 10f, 0f, 100f); //health + max 50, more than 0, less than 100
               health = Mathf.Clamp01(health + 10f / healthTimeout); //health + max 50, more than 0, less than 100
        }

        if(other.CompareTag("banana"))
        {
            Destroy(other.gameObject);
            health = Mathf.Clamp(health + 5f, 10f, 100f); //health + max 50, more than 0, less than 100
        }

          if(other.CompareTag("pipe"))
        {
            Loose();
        }

        Debug.Log(health);
    }


    private void Loose() 
    {
        tries -=1;
            triesTmp.text = tries.ToString();
            if(tries > 0){
                health = 1.0f;
            AlertScript.Show("Collision", "You hit an obstacle and loose a life", "Continue", DestroyerScript.ClearField);
            }
            else
            {
                  AlertScript.Show("Collision", "Game over", "Restart", () => SceneManager.LoadScene(0));
            }
    }
}

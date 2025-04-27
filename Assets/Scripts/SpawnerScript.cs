using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerScript : MonoBehaviour
{
    [SerializeField]
    private GameObject pipePreFab;

    [SerializeField]
    private GameObject foodPreFab;

    [SerializeField]
    private GameObject food1PreFab;

    private float pipeOffsetMax = 2.0f;
    private float foodOffsetMax = 4.0f;
    private float food1OffsetMax = 3.0f;
    private float period = 3.0f;
    private float timeout;
    private float foodTimeout;
    private float food1Timeout;
    void Start()
    {
        timeout = 0f; // period
        foodTimeout = period * 1.5f; // |   |   |   |
                                     //       ^ period * 1.5

        food1Timeout = period * 5.5f;
    }

    void Update()
    {
         timeout -= Time.deltaTime;
        
        if(timeout < 0)
        {
            timeout = period;
            SpawnPipe();
        }


          foodTimeout -= Time.deltaTime;
     
          if(foodTimeout < 0)
        {
            foodTimeout = period;
            SpawnFood();
        }

          food1Timeout -= Time.deltaTime;
     
          if(food1Timeout < 0)
        {
            food1Timeout = period;
            SpawnFood1();
        }
        
        
    }

    private void SpawnPipe()
    {
       GameObject pipe = GameObject.Instantiate(pipePreFab);
       pipe.transform.position = transform.position + Random.Range(-pipeOffsetMax, +pipeOffsetMax) * Vector3.up;
       
    }

    private void SpawnFood()
    {
       GameObject food = GameObject.Instantiate(foodPreFab);
       food.transform.position = transform.position + Random.Range(-foodOffsetMax, +foodOffsetMax)* Vector3.up;
       food.transform.Rotate(0, 0, Random.Range(0, 360));
       
    }

      private void SpawnFood1()
    {
       GameObject food1 = GameObject.Instantiate(food1PreFab);
       food1.transform.position = transform.position + Random.Range(-food1OffsetMax, +food1OffsetMax)* Vector3.up;
       food1.transform.Rotate(0, 0, Random.Range(0, 360));
       
    }
}

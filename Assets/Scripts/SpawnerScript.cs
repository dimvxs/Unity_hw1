using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerScript : MonoBehaviour
{

  // public static float difficulty = 0.5f;
  public static float _difficulty = 0.5f;
  public static float difficulty {
    get => _difficulty;
    set{
      _difficulty = value;
      foodTimeout = timeout + period * 0.5f;
      food1Timeout = timeout + period * 0.5f;
    }
  }
    [SerializeField]
    private GameObject pipePreFab;

    [SerializeField]
    private GameObject foodPreFab;

    [SerializeField]
    private GameObject food1PreFab;

    private float pipeOffsetMax = 2.0f;
    private float foodOffsetMax = 4.0f;
    private float food1OffsetMax = 1.0f;
    // private float period = 3.0f;
    private static float period => 6.0f - 4.0f * difficulty;
    private static float timeout;
    private static float foodTimeout;
    private static float food1Timeout;

    public static int bananasCount;
    public static int pipesCount;
    public static int ladybugsCount;



    void Start()
    {
        timeout = 0f; // period
        foodTimeout = period * 1.5f; // |   |   |   |
                                     //       ^ period * 1.5

        food1Timeout = period * 2.5f;

        pipesCount = 0;
        bananasCount = 0;
        ladybugsCount = 0;
    }

    void Update()
    {
         timeout -= Time.deltaTime;
        
        if(timeout < 0)
        {
            timeout = period;
            SpawnPipe();
            pipesCount += 1;
        }


          foodTimeout -= Time.deltaTime;
     
          if(foodTimeout < 0)
        {
            foodTimeout = period;
            SpawnFood();
            ladybugsCount += 1;
        }

          food1Timeout -= Time.deltaTime;
     
          if(food1Timeout < 0)
        {
            food1Timeout = period;
            SpawnFood1();
            bananasCount += 1;
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

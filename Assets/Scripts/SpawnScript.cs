using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnScript : MonoBehaviour
{
    [SerializeField]
    private GameObject pipePrefab;
    private float period = 5.0f;
    private float timeout;
    // Start is called before the first frame update
    void Start()
    {
        timeout = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        timeout -= Time.deltaTime;

        if(timeout < 0)
        {
            timeout = period;
            SpawnPipe();
        }
    }

    private void SpawnPipe()
    {
        GameObject pipe = GameObject.Instantiate(pipePrefab);
        pipe.transform.position = this.transform.position;
    }
}

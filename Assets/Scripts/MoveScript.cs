using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveScript : MonoBehaviour
{
    // [SerializeField]
    private float speed = 1.5f;
  

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(speed * Time.deltaTime * Vector3.left, Space.World);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class ControlScript : MonoBehaviour
{
    private Rigidbody2D rb; //link to the component
    // private InputAction moveAction;


    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        // moveAction = InputSystem.actions.FindAction("Move");
    }

    // Update is called once per frame
    void Update()
    {
        //управление - анализ игрока
        // input - прямой доступ к устройствам (клавиатура, мышь, джойстик)
        // if(Input.GetKeyDown(KeyCode.Space))
        // {
        // rb.AddForce(Vector2.up * 200f);
        // }

        // if(Input.GetKey(KeyCode.W))
        // {
        // rb.AddForce(Vector2.up * 10f);
        // }

        //Input manager - обьеденение разных способ управления по осям
        // float y = Input.GetAxis("Vertical");
        // rb.AddForce(5f * y * Vector2.up);



        //Input System - обьединение осей в векторы
        // rb.AddForce(5f * moveAction.ReadValue<Vector2>());
    }
}

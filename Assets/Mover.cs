using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField]float MoveSpeed=2.0f;
     
    



    // Start is called before the first frame update
    void Start()
    {
       PrintInstruction();
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer(); 
    }

    void PrintInstruction(){
        Debug.Log("Welcome to the game");

        Debug.Log("This is a collision game");

        Debug.Log("Don't hit the walls");
    }

    void MovePlayer(){
        float xValue=Input.GetAxis("Horizontal")*Time.deltaTime*MoveSpeed;
        float zValue=Input.GetAxis("Vertical")*Time.deltaTime*MoveSpeed;
        transform.Translate(xValue,0,zValue); 
    }

    
}

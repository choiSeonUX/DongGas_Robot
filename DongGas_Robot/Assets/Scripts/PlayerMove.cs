using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{

    Rigidbody rigidbody;
    Vector3 robotPosition; 

    [SerializeField]
    private float robotSpeed = 4f;

    [SerializeField]
    GameObject robot1;

    [SerializeField]
    GameObject robot2; 

    private void Start()
    {
        rigidbody = GetComponent<Rigidbody>(); 
    }

    private void Update()
    {

        if (gameObject.gameObject.tag == "Robot1")
        {
            if (Input.GetKeyDown(KeyCode.Alpha1))
                RobotMove();
        }
        if (gameObject.gameObject.tag == "Robot 2")
        {
            if (Input.GetKeyDown(KeyCode.Alpha2))
                RobotMove();
        }

    }

    public void RobotMove()
    {
        robotPosition = transform.position; 

        if(Input.GetKey(KeyCode.W))
        {
            robotPosition += Vector3.forward * robotSpeed * Time.deltaTime;
            rigidbody.MovePosition(robotPosition); 
        }

        if(Input.GetKey(KeyCode.A))
        {
            robotPosition -= Vector3.left * robotSpeed * Time.deltaTime;
            rigidbody.MovePosition(robotPosition);
        }

        if (Input.GetKey(KeyCode.S))
        {
            robotPosition -= Vector3.forward * robotSpeed * Time.deltaTime;
            rigidbody.MovePosition(robotPosition);
        }

        if (Input.GetKey(KeyCode.D))
        {
            robotPosition += Vector3.left * robotSpeed * Time.deltaTime;
            rigidbody.MovePosition(robotPosition);
        }

    }

}
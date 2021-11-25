using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMotor : MonoBehaviour
{

    public CameraMotor cameramotor;


    public float interpVelocity;
    public float minDistance;
    public float followDistance;
    public GameObject target;
    public Vector3 offset;
    Vector3 targetPos;
    // Use this for initialization
    void Start()
    {
        target = GameObject.Find("Player");
        targetPos = transform.position;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (target)
        {
            Vector3 posNoZ = transform.position;
            posNoZ.z = target.transform.position.z;

            Vector3 targetDirection = (target.transform.position - posNoZ);

            interpVelocity = targetDirection.magnitude * 5f;

            targetPos = transform.position + (targetDirection.normalized * interpVelocity * Time.deltaTime);

            transform.position = Vector3.Lerp(transform.position, targetPos + offset, 0.25f);

        }
    }

    




}





























/*
public Transform lookAt;
public float boundX = 0.15f;
public float boundY = 0.05f;

private void Start()
{
    lookAt = GameObject.Find("Player").transform;
}


private void LateUpdate()
{
    Vector3 delta = Vector3.zero;

    float deltaX = lookAt.position.x - transform.position.x;
    if(deltaX > boundX || deltaX <-boundX)
    {
        if (transform.position.x < lookAt.position.x)
        {
            delta.x = deltaX - boundX;
        }
        else
        {
            delta.x = deltaX + boundX;
        }
    }


    float deltaY = lookAt.position.y - transform.position.y;
    if (deltaY > boundY || deltaY < -boundY)
    {
        if (transform.position.y < lookAt.position.y)
        {
            delta.y = deltaY - boundY;
        }
        else
        {
            delta.y = deltaY + boundY;
        }
    }


    transform.position += new Vector3(delta.x, delta.y, 0);

}

*/





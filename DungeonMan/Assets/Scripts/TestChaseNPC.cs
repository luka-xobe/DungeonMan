using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestChaseNPC : MonoBehaviour
{
    GameObject grid;

    public float speed = 3.0f;
    public float ObstacleRange = 5.0f;

    void Start()
    {
        grid = GameObject.Find("Floor");
        
    }

    void Update()
    {
        transform.Translate(speed * Time.deltaTime, 0, 0);

        Ray2D ray2D = new Ray2D(transform.position, transform.forward);
        RaycastHit2D hit = Physics2D.Raycast(transform.position, transform.TransformDirection(Vector3.right), ObstacleRange);
        if (hit)
        {

            if (hit.distance < ObstacleRange && !grid)
            {
                //float angle = Random.Range(-110, 110);
                //transform.localScale = new Vector3(-1, 1, 1);
                //transform.position = new Vector3(x, y, z);
                //transform.Translate(-speed * Time.deltaTime, 0, 0);
                transform.Rotate(0, 180, 0);
                Debug.Log("Pdsdsd");
            }
        }


    }


}

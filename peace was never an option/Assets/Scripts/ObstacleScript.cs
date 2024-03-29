using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleScript : MonoBehaviour
{
    public float moveSpeed = 10;
    public float deadZone = -12;

    // Update is called once per frame
    void Update()
    {
        moveLeft();
        remove();
    }

    public void moveLeft()
    {
        transform.position = transform.position + Vector3.left * moveSpeed * Time.deltaTime;
    } 

    public void remove()
    {
        if (transform.position.x < deadZone)
        {
            Destroy(gameObject);
        }
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CoinScript : MonoBehaviour
{
    public float moveSpeed = 10;
    public float deadZone = -12;
    public LogicScript logic;

    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }
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

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 3)
        {
            logic.increaseCoins();
            Destroy(gameObject);
        }
    }
}

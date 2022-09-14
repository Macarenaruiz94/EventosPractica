using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerScript : MonoBehaviour
{
    [SerializeField] private float move;
    [SerializeField] private int speed;
    Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Movement();
    }

    void Movement()
    {
        move = Input.GetAxisRaw("Horizontal");
        transform.position += new Vector3(move, 0, 0) * Time.deltaTime * speed;
    }

    public void Die()
    {
        Destroy(this.gameObject);
    }

    private void OnEnable()
    {
        obstacleScript.PlayerDeath += Die;
    }

    private void OnDisable()
    {
        obstacleScript.PlayerDeath -= Die;
    }
}

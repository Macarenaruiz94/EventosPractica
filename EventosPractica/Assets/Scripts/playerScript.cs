using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerScript : MonoBehaviour
{

    void Start()
    {
        
    }

    void Update()
    {
        Movement();
    }

    void Movement()
    {

    }

    public void Die()
    {
        Destroy(gameObject);
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

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class winScript : MonoBehaviour
{
    public static event Action WinGame;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            WinGame?.Invoke();
        }
    }
}

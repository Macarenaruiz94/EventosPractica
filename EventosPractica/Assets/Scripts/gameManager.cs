using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameManager : MonoBehaviour
{
    void Win()
    {
        Debug.Log("Yay!");
    }

    private void OnEnable()
    {
        winScript.WinGame += Win;
    }

    private void OnDisable()
    {
        winScript.WinGame -= Win;
    }
}

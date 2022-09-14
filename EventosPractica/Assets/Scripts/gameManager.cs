using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameManager : MonoBehaviour
{
    public void Win()
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

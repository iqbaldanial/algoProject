using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collider : MonoBehaviour
{
    // Reference to the UI element
    public GameObject GameOverUI;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            // Activate the UI element
            GameOverUI.SetActive(true);
        }
    }
}


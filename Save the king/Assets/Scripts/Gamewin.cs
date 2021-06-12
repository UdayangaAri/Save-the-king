using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gamewin : MonoBehaviour
{
    public gameManager gameManager;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Destroy(other.gameObject);
            gameManager.gameWin();
        }

    }
}

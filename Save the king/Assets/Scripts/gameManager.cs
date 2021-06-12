using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameManager : MonoBehaviour
{
    public GameObject gameObj;
    // Start is called before the first frame update
    void Start()
    {
        //gameObj.SetActive(false);
    }

   public void gameOver()
    {
        //Debug.Log("Player Died 01 ");
        gameObj.SetActive(true);
        //Debug.Log("Player Died 02 ");
    }

    public void gameWin()
    {
        //Debug.Log("Player Died 01 ");
        gameObj.SetActive(true);
        //Debug.Log("Player Died 02 ");
    }
}

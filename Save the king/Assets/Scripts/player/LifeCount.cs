using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LifeCount : MonoBehaviour
{
    public Image[] lives;
    public int livesRemaining;
    public gameManager gameManager;
    public Animator animator;
    public GameObject player;

    PlayerMovements playerMovements;
    //4 lives - 4 imgaes (0,1,2,3)
    //3 lives - 3 images (0,1,2,[3])
    //2 lives - 2 images (0,1,[2],[3])
    //1 life - 1 image (0,[1],[2],[3])
    //0 lives - 0 images ([0,1,2,3]) LOSE

    public void LoseLife()
    {

        if (livesRemaining == 0)
            return;
        
        livesRemaining--;
       
        lives[livesRemaining].enabled = false;

        if (livesRemaining==0)
        {
            /*
            animator.SetTrigger("isDie");
            playerMovements.accidednt();
            */
            //Debug.Log("gameover ACCIDENT");
            player.SetActive(false);
            gameManager.gameOver();
           
        }
    }

    private void Update()
    {

    }

}
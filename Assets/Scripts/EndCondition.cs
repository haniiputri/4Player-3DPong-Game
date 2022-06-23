using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndCondition : MonoBehaviour
{
    GameObject gamePanel;

    public int count = 4;
 
    void Start()
    {
        gamePanel = GameObject.Find("GamePanel"); gamePanel.SetActive(false);
    }

    public void LosePlayer(GameObject player, GameObject wall)
    {
        wall.gameObject.GetComponent<Collider>().isTrigger = false;
        player.SetActive(false);
        count--;
        if (count == 1)
        {
            GameOver();
        }
    }

    public void GameOver()
    {
        gamePanel.SetActive(true);
    }
}

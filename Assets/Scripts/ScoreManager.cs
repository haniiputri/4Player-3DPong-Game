using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    public int scoreR;
    public int scoreL;
    public int scoreB;
    public int scoreT;

    public GameObject PlayerR;
    public GameObject PlayerL;
    public GameObject PlayerT;
    public GameObject PlayerB;

    public GameObject WallR;
    public GameObject WallL;
    public GameObject WallT;
    public GameObject WallB;

    public EndCondition endGame;

    public void RightScore(int dec)
    {
        scoreR -= dec;
    
        if (scoreR <= 0)
        {
            endGame.LosePlayer(PlayerR, WallR);
        }
    }

    public void LeftScore(int dec)
    {
        scoreL -= dec;

        if (scoreL <= 0)
        {
            endGame.LosePlayer(PlayerL, WallL);
        }
    }

    public void BottomScore(int dec)
    {
        scoreB -= dec;

        if (scoreB <= 0)
        {
            endGame.LosePlayer(PlayerB, WallB);
        }
    }

    public void TopScore(int dec)
    {
        scoreT -= dec;

        if (scoreT <= 0)
        {
            endGame.LosePlayer(PlayerT, WallT);
        }
    }
}

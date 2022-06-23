using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalControl : MonoBehaviour
{
    public Collider bola;

    public Vector3 resetPosition;
    public Vector3 startForce;

    private int count;

    public bool isRight;
    public bool isLeft;
    public bool isBottom;
    public bool isTop;
    public ScoreManager manager;


    private void OnTriggerEnter(Collider other)
    {
        BallControl ball = other.gameObject.GetComponent<BallControl>();
        if (ball != null)
        {
            ball.transform.position = new Vector3(resetPosition.x, resetPosition.y, resetPosition.z);
            Rigidbody rigidbody = other.gameObject.GetComponent<Rigidbody>();
            rigidbody.AddForce(startForce, ForceMode.Impulse);

            if (isRight)
            {
                manager.RightScore(1);
            }
            else if(isLeft)
            {
                manager.LeftScore(1);
            }
            else if (isTop)
            {
                manager.TopScore(1);
            }
            else if (isBottom)
            {
                manager.BottomScore(1);
            }

        }

    }
}

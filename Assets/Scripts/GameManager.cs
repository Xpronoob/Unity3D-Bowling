using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private float shotForce = 30.0F;

    [SerializeField]
    private float moveDistance = 0.15F;

    [SerializeField]
    private Rigidbody ball;

    public void OnShot() 
    { 
        ball.AddForce(ball.transform.forward * shotForce, ForceMode.Impulse);
    }

    public void OnMoveLeft()
    {
        ball.transform.position += ball.transform.right * -moveDistance;
    }

    public void OnMoveRight()
    {
        ball.transform.position += ball.transform.right * moveDistance;
    }
}

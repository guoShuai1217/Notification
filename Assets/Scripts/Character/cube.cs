/*
 * 
 *   Title : "" 项目
 *
 *   Description :
 *
 *   Author : guoShuai
 *
 *   Data : 2018
 *
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cube : CharacterBase
{

    private void Awake()
    {
        Bind(CharacterEvent.MOVE);
    }


    public override void Execute(int eventCode, object message)
    {
        switch (eventCode)
        {
            case CharacterEvent.MOVE:
                Move((Vector3)message);
                break;
            default:
                break;
        }
    }

    private Vector3 euler;
    private Vector3 move;
    private void Move(Vector3 dir)
    {
        float angle = Mathf.Atan2(dir.x, dir.y) * Mathf.Rad2Deg;
        this.euler.y = angle;
        transform.rotation = Quaternion.Euler(euler);

        float speedX = Mathf.Abs(dir.x);
        float speedY = Mathf.Abs(dir.y);
        float tempSpeed = Mathf.Sqrt(speedY * speedY + speedX * speedX );
        move.x = dir.x;
        move.y = 0;
        move.z = dir.y;
        transform.GetComponent<CharacterController>().SimpleMove(move * tempSpeed * 0.00005f);
    }



}

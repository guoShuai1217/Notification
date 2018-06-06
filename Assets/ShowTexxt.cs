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

public class ShowTexxt : UIBase
{

    private void Awake()
    {
        Bind(UIEvent.SHOW_TEXT);
    }

    public override void Execute(int eventCode, object message)
    {
        switch (eventCode)
        {
            case UIEvent.SHOW_TEXT:
                SHOW(message.ToString());
                break;
            default:
                break;
        }
    }


    void SHOW(string message)
    {
        transform.Find("Text").GetComponent<Text>().text = message;
    }

}

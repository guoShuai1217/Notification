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
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Login : UIBase
{

    private Button btn;

    private void Start()
    {
        btn = transform.Find("Button").GetComponent<Button>();
        btn.onClick.AddListener(OnClickBtn);
    }

    private void OnClickBtn()
    {
         Dispatch(AreaCode.AUDIO , AudioEvent.PLAY_AUDIO,"bgMusic");
        Dispatch(AreaCode.UI, UIEvent.SHOW_TEXT, "我收到消息啦");
    }
}

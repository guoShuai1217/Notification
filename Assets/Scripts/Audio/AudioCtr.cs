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

public class AudioCtr : AudioBase
{
    private void Awake()
    {
        Bind(AudioEvent.PLAY_AUDIO);
    }

    public override void Execute(int eventCode, object message)
    {
        switch (eventCode)
        {
            case AudioEvent.PLAY_AUDIO:
                print("已经播放了音乐" + message.ToString());
                break;
            default:
                break;
        }
    }


}

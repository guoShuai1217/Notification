/*
 * 
 *   Title : "Notification" 项目
 *
 *   Description : 消息处理中心, 只负责消息的转发
 *    比如 : UI -> MsgCenter -> Character
 *
 *   Author : guoShuai
 *
 *   Data : 2018.6.5
 *
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MsgCenter : MonoBase
{
    public static MsgCenter Instance;
 
    private void Awake()
    {
        Instance = this;

        gameObject.AddComponent<UIManager>();
        gameObject.AddComponent<AudioManager>();
        gameObject.AddComponent<CharacterManager>();
        
        DontDestroyOnLoad(gameObject);
    }
    /// <summary>
    /// 发送消息 , 所有的发消息,都要通过这个方法
    /// </summary>
    /// <param name="areaCode">区域码</param>
    /// <param name="eventCode">事件码</param>
    /// <param name="message"> 传递的消息参数 </param>>
    public void Dispatch(int areaCode,int eventCode,object message)
    {
        switch (areaCode)
        {
            case AreaCode.UI:
                UIManager.Instance.Execute(eventCode, message);
                break;
            case AreaCode.GAME:
                break;
            case AreaCode.CHARACTER:
                CharacterManager.Instance.Execute(eventCode, message);
                break;
            case AreaCode.AUDIO:
                AudioManager.Instance.Execute(eventCode, message);
                break;
            case AreaCode.NET:
                break;
            case AreaCode.SCENE:
                break;
            default:
                break;
        }
    }

}

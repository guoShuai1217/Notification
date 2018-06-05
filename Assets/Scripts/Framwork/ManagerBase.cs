/*
 * 
 *   Title : "" 项目
 *
 *   Description : 每个模块的基类 , UI,GAEM,CHARACTER,SCENE,AUDIO 每个模块都有继承它 ;
 *   
 *   处理自身的消息
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

/// <summary>
/// 管理基类,所有模块的管理类都要继承它
/// </summary>
public class ManagerBase : MonoBase
{
    
    // 存储消息的事件码
    private Dictionary<int, List<MonoBase>> dic = new Dictionary<int, List<MonoBase>>();


    /// <summary>
    /// 处理自身的消息
    /// </summary>
    /// <param name="eventCode"></param>
    /// <param name="message"></param>
    public override void Execute(int eventCode, object message)
    {
        if (!dic.ContainsKey(eventCode))
        {
            Debug.LogError("没注册" + eventCode);
            return;
        }

        List<MonoBase> list = dic[eventCode];

        for (int i = 0; i < list.Count; i++)
        {
            list[i].Execute(eventCode, message);
        }

    }




    /// <summary>
    /// 注册单个事件
    /// </summary>
    /// <param name="eventCode">事件码</param>
    /// <param name="mono">要注册的脚本</param>
	public void Regist(int eventCode,MonoBase mono)
    {
        List<MonoBase> list = null;
        // 之前没注册过
        if (!dic.ContainsKey(eventCode))
        {
            list = new List<MonoBase>();
            list.Add(mono);

            dic.Add(eventCode, list);
            return;
        }

        // 之前注册过

        list = dic[eventCode];
        list.Add(mono);
    }

    /// <summary>
    /// 注册多个事件
    /// </summary>
    /// <param name="eventCodes"></param>
    /// <param name="mono"></param>
    public void Regist(int[] eventCodes , MonoBase mono)
    {
        for (int i = 0; i < eventCodes.Length; i++)
        {
            Regist(eventCodes[i], mono);
        }
    }

    /// <summary>
    /// 注销单个事件
    /// </summary>
    /// <param name="eventCode"></param>
    /// <param name="mono"></param>
    public void UnRegist(int eventCode, MonoBase mono)
    {
        if (!dic.ContainsKey(eventCode))
        {
            Debug.Log("没这个事件" + eventCode + "注册");
            return;
        }

        List<MonoBase> list = dic[eventCode];
        if (list.Count == 1)      
            dic.Remove(eventCode);  
        else
            list.Remove(mono);
    }

    /// <summary>
    /// 注销多个事件
    /// </summary>
    /// <param name="eventCodes"></param>
    /// <param name="mono"></param>
    public void UnRegist(int[] eventCodes, MonoBase mono)
    {
        for (int i = 0; i < eventCodes.Length; i++)
        {
            UnRegist(eventCodes[i], mono);
        }
    }


}

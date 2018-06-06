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

public class AudioBase : MonoBase
{
    // 自身关系的消息集合
    public List<int> list = new List<int>();


    /// <summary>
    /// 绑定一个或者多个消息
    /// </summary>
    /// <param name="evenetCode"></param>
    protected void Bind(params int[] evenetCode)
    {
        list.AddRange(evenetCode);
        AudioManager.Instance.Regist(list.ToArray(),this);
    }
	 

    /// <summary>
    /// 解除绑定的消息
    /// </summary>
    protected void UnBind()
    {
        AudioManager.Instance.UnRegist(list.ToArray(), this);
    }
	 
    /// <summary>
    /// 物体销毁时自动解绑消息
    /// </summary>
    public virtual void OnDestroy()
    {
        if (list != null)
            UnBind();
    }

    /// <summary>
    /// 发消息
    /// </summary>
    /// <param name="areaCode"></param>
    /// <param name="eventCode"></param>
    /// <param name="message"></param>
    public void Dispatch(int areaCode, int eventCode, object message)
    {
        MsgCenter.Instance.Dispatch(areaCode, eventCode, message);
    }

}

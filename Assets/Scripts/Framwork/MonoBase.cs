/*
 * 
 *   Title : "Notification" 项目
 *
 *   Description : 通过消息通知降低耦合度 
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
/// 扩展 MonoBehaviour 类
/// </summary>
public class MonoBase : MonoBehaviour
{
   
    public virtual void Execute(int eventCode,object message) { }
	 
}

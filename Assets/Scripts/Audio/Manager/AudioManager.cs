/*
 * 
 *   Title : "" 项目
 *
 *   Description : 音频管理器 , 继承 ManagerBase 所有模块的管理器都有继承它
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

/// <summary>
/// 音频管理器,继承自 ManagerBase
/// </summary>
public class AudioManager : ManagerBase
{

    public static AudioManager Instance;

    private void Awake()
    {
        Instance = this;
    }








}

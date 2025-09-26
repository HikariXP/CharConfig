/*
 * Author: CharSui
 * Created On: 2025.09.26
 * Description: 配置实例接口
 */
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IConfigUnit
{
    public bool TryInitialize<T>(Dictionary<string, T> data);

    public bool TryRelease();

    public T GetConfig<T>(string key);
}

/*
 * Author: CharSui
 * Created On: 2025.09.26
 * Description: 配置实例接口
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IConfigUnit<T>
{
	public T GetConfig(string key);
}

/*
 * Copyright (c) PeroPeroGames Co., Ltd.
 * Author: CharSui
 * Created On: #CREATE_TIME#
 * Description: 
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IAssetLoader
{
	/// <summary>
	/// 加载资源
	/// </summary>
	/// <typeparam name="T">资源类型</typeparam>
	/// <param name="path">资源路径</param>
	/// <returns>加载到的资源</returns>
	T LoadAsset<T>(string path) where T : UnityEngine.Object;
}

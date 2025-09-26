/*
 * Copyright (c) PeroPeroGames Co., Ltd.
 * Author: CharSui
 * Created On: 2025.09.26
 * Description: 选定资源类型(Json、Xml、Excel)--->对应的加载器(JsonLoader)--->配置实例(具体类型的存储器)--->使用(获取配置实例)
 */

using System.Collections.Generic;
using UnityEngine;

public class CharConfig : MonoBehaviour
{
	private Dictionary<string, IConfigUnit> cachedConfigs = new Dictionary<string, IConfigUnit>(32);

    public void UnloadAll()
	{
		
	}

	public void Unload(string key)
	{
		
	}
}

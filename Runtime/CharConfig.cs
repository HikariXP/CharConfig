/*
 * Copyright (c) PeroPeroGames Co., Ltd.
 * Author: CharSui
 * Created On: 2025.09.26
 * Description: 选定资源类型(Json、Xml、Excel)--->对应的加载器(JsonLoader)--->配置实例(具体类型的存储器)--->使用(获取配置实例)
 */

using System.Collections.Generic;
using UnityEngine;
using CharFramework.Module;
using CharFramework.Singleton;

public class CharConfig : Singleton<CharConfig>,  IModule
{
	private Dictionary<System.Type, object> configTables = new Dictionary<System.Type, object>();
	
	private IAssetLoader _assetLoader;
    
	public void Initialize(IAssetLoader assetLoader)
	{
		if (assetLoader == null)
		{
			CharLogger.LogError("AssetLoader is null.");
			return;
		}

		_assetLoader = assetLoader;
		// 注册所有配置表(Runtime示例)
		// RegisterConfig<ItemConfigTable>("Configs/Items");
		// RegisterConfig<SkillConfigTable>("Configs/Skills");
		// RegisterConfig<MonsterConfigTable>("Configs/Monsters");
	}
    
	public void RegisterConfig<T>(string configPath) where T : new()
	{
		var table = new T();
		var configContext = _assetLoader.LoadAsset<TextAsset>(configPath);
        
		if (configContext != null)
		{
			var loadMethod = table.GetType().GetMethod("Load");
			loadMethod?.Invoke(table, new object[] { configContext.text });
			configTables[typeof(T)] = table;
		}
		else
		{
			Debug.LogError($"Config file not found: {configPath}");
		}
	}
    
	public T GetConfigTable<T>() where T : class
	{
		if (configTables.TryGetValue(typeof(T), out var table))
		{
			return table as T;
		}
		return null;
	}
}
/*
 * Copyright (c) PeroPeroGames Co., Ltd.
 * Author: CharSui
 * Created On: #CREATE_TIME#
 * Description: 
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Newtonsoft;

public class JsonLoader
{
	public Dictionary<string, T> LoadDictionary<T>(string jsonString)
	{
		if(string.IsNullOrEmpty(jsonString)) return null;

		var result = Newtonsoft.Json.JsonConvert.DeserializeObject<Dictionary<string, T>>(jsonString);
		return result;
	}
}

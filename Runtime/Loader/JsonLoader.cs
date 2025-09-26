/*
 * Copyright (c) PeroPeroGames Co., Ltd.
 * Author: CharSui
 * Created On: #CREATE_TIME#
 * Description: 
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JsonLoader<T> : where T :struct 
{
	public Dictionary<string, T> Load(string path)
	{
		
		
		// var text = System.IO.File.ReadAllText(path);
		// var dict = MiniJSON.Json.Deserialize(text) as Dictionary<string, object>;
		// return dict;
	}
}

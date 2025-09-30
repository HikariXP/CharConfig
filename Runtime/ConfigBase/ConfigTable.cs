/*
 * Author: CharSui
 * Created On: 2025.09.30
 * Description: 配置数据基类
 */

using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

public abstract class ConfigData
{
	public int Id;
}

// 配置表基类
public abstract class ConfigTable<T> where T : ConfigData
{
	protected Dictionary<int, T> dataDict = new Dictionary<int, T>();
    
	public virtual void Load(string jsonText)
	{
		// 直接反序列化为List<T>，而不是通过包装类
		var dataList = JsonConvert.DeserializeObject<List<T>>(jsonText);
		foreach (var data in dataList)
		{
			dataDict[data.Id] = data;
		}
	}
    
	public T GetById(int id)
	{
		return dataDict.TryGetValue(id, out var data) ? data : null;
	}
    
	public List<T> GetAll()
	{
		return dataDict.Values.ToList();
	}
}

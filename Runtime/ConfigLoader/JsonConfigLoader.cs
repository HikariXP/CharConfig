/*
 * Author: CharSui
 * Created On: 2025.09.30
 * Description: Json配置加载器
 */
public class JsonConfigLoader : IConfigLoader
{
	public T LoadConfig<T>(string context) where T : class
	{
		return string.IsNullOrEmpty(context) ? Newtonsoft.Json.JsonConvert.DeserializeObject<T>(context) : null;
	}
}
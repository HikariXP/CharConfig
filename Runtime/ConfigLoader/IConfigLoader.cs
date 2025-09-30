/*
 * Author: CharSui
 * Created On: 2025.09.30
 * Description: 配置文件加载器接口
 */
public interface IConfigLoader
{
	T LoadConfig<T>(string context) where T : class;
}
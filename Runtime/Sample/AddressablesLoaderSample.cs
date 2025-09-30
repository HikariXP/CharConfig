/*
 * Author: CharSui
 * Created On: 2025.09.30
 * Description: Addressables资源加载器
 */

// using UnityEngine;
// using UnityEngine.AddressableAssets;
//
// public class AddressablesLoader : IAssetLoader
// {
// 	public T LoadAsset<T>(string path) where T : Object
// 	{
// 		// 慎用，如果同步加载的Path是错的，会卡死主线程
// 		var op = Addressables.LoadAssetAsync<T>(path);
// 		op.WaitForCompletion();
// 		
// 		return op.Result;
// 	}
// }
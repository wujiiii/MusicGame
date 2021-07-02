using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PutSingleton<T> : MonoBehaviour where T:MonoBehaviour
{
    private static GameObject _relyObj;//依赖物品
    //public static string ObjName = "MonoSingleObject";
    static T _instance;
    public static T Instance
    {
        get
        {
            if (_relyObj == null)
            {
                return null;
            }
            else
            {
                return _instance;
            }
        }
    }
    private void Awake()
    {
        if (_relyObj == null)
        {
            _relyObj = transform.gameObject;//将现在所挂载的物体构建
            _instance = transform.GetComponent<T>();
        }
        else
        {
            Destroy(transform.gameObject);
            Debug.Log("========单例销毁=========");
        }
    }
}

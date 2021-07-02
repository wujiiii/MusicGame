using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PutSingleton<T> : MonoBehaviour where T:MonoBehaviour
{
    private static GameObject _relyObj;//������Ʒ
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
            _relyObj = transform.gameObject;//�����������ص����幹��
            _instance = transform.GetComponent<T>();
        }
        else
        {
            Destroy(transform.gameObject);
            Debug.Log("========��������=========");
        }
    }
}

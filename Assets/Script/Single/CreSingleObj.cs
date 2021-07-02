using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//�ɴ����Ĳ��̳���Monobehaviour�ĵ���
public abstract class CreSingleObj<T> : MonoBehaviour where T:MonoBehaviour//�������崴���ű�
{
    private static GameObject _relyObj;
    public static string ObjName = "MonoSingleObject";
    static T _instance;
    public static T Instance
    {
        get
        {
            if (_relyObj == null)
            {
                _relyObj = new GameObject(ObjName);
            }
            if (_relyObj != null)
            {
                _instance = _relyObj.AddComponent<T>();
            }
            return _instance;
        }
    }
}

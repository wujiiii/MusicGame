using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//ÆÕÍ¨·ºÐÍµ¥Àý
public abstract class Singleton<T> where T : new()
{
    private static T _instance;
    public static T Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new T();
            }
            return _instance;
        }
    }
}
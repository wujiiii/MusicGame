using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var a = test.Instance;
        Debug.Log(a.gameObject.name);
        DealFile.WriteStrToFile("=========", "a.txt");
        Debug.Log(DealFile.ReadStrFromFile("a.txt"));
    }

    // Update is called once per frame
}

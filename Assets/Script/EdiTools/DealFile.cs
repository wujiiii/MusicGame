using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using UnityEngine;
//处理文件类
public class DealFile
{
    public static void WriteStrToFile(string _test,string path)//将文件写入指定文件夹
    {
        FileStream fs;
        if (!File.Exists(Application.streamingAssetsPath + "/" + path))
        {
            fs = File.Open(Application.streamingAssetsPath + "/" + path, FileMode.OpenOrCreate);//创建或者打开
        }
        else
        {
            fs = File.Open(Application.streamingAssetsPath + "/" + path, FileMode.Open);
        }
        //File file = new File()
        byte[] bytes = Encoding.UTF8.GetBytes(_test);
        fs.Write(bytes, 0, _test.Length);
        fs.Close();
    }
    //读取指定路径下的文件并返回
    public static string ReadStrFromFile(string path)
    {
        string str = "";
        StreamReader sr = new StreamReader(Application.streamingAssetsPath + "/" + path, Encoding.UTF8);
        try
        {
            str = sr.ReadToEnd();//从开始读到结尾
        }
        catch (System.Exception e)
        {
            //Debug.Log(e.ToString());
        }
        sr.Close();
        return str;
    }
}

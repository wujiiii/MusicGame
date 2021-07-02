using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using UnityEngine;
//�����ļ���
public class DealFile
{
    public static void WriteStrToFile(string _test,string path)//���ļ�д��ָ���ļ���
    {
        FileStream fs;
        if (!File.Exists(Application.streamingAssetsPath + "/" + path))
        {
            fs = File.Open(Application.streamingAssetsPath + "/" + path, FileMode.OpenOrCreate);//�������ߴ�
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
    //��ȡָ��·���µ��ļ�������
    public static string ReadStrFromFile(string path)
    {
        string str = "";
        StreamReader sr = new StreamReader(Application.streamingAssetsPath + "/" + path, Encoding.UTF8);
        try
        {
            str = sr.ReadToEnd();//�ӿ�ʼ������β
        }
        catch (System.Exception e)
        {
            //Debug.Log(e.ToString());
        }
        sr.Close();
        return str;
    }
}

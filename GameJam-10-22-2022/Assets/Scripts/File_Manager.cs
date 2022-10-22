using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class File_Manager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        WriteString();
    }

    // Update is called once per frame
    void Update()
    {

    }
    public static void WriteString()
    {

        //string path = Application.persistentDataPath + "/test.txt";
        //string sors = "C:/Users/Lazar/Desktop" + "/sors.txt";
        //string destination = "C:/Users/escape" + "/testtt.txt";
        string path = Path.GetFullPath("./");
        int pom = 0;
        string actual_path = "";


        char[] main_path = path.ToCharArray();
        for (int i = 0; i < main_path.Length; i++)
        {
            if ((int)main_path[i] == 92)
            {
                pom++;
                if (pom == 2)
                {
                    Debug.Log("OVO" + actual_path);
                    break;
                }

                Debug.Log("ovoliko puta smo usli u if sa equals " + pom);
            }
            actual_path = actual_path.Insert(i, main_path[i].ToString());
            Debug.Log("ovo nije u if" + actual_path);
        }
        StreamWriter writer = new StreamWriter(actual_path + "/test.txt", true);
        writer.WriteLine("tttest");
        writer.Close();

        //StreamReader reader = new StreamReader(sors);
        //string text = reader.ReadToEnd();
        //reader.Close();

        //Write some text to the test.txt file


    }
    //public static void ReadString()
    //{
    //    string path = Application.persistentDataPath + "/test.txt";
    //    //Read the text from directly from the test.txt file
    //    StreamReader reader = new StreamReader(path);
    //    Debug.Log(reader.ReadToEnd());
    //    reader.Close();
    //}
}

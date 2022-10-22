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
        string sors = "C:/Users/Lazar/Desktop" + "/sors.txt";
        string destination = "C:/Users/Lazar/Desktop" + "/escape.txt";

        StreamReader reader = new StreamReader(sors);
        string text = reader.ReadToEnd();
        reader.Close();

        //Write some text to the test.txt file
        StreamWriter writer = new StreamWriter(destination, true);
        writer.WriteLine(text);
        writer.Close();
        
        //Print the text from the file
       // Debug.Log(reader.ReadToEnd());
       // reader.Close();
    }
    public static void ReadString()
    {
        string path = Application.persistentDataPath + "/test.txt";
        //Read the text from directly from the test.txt file
        StreamReader reader = new StreamReader(path);
        Debug.Log(reader.ReadToEnd());
        reader.Close();
    }
}

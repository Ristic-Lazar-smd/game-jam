using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class File_Manager : MonoBehaviour
{
    static string base_file_path;
    // Start is called before the first frame update
    void Start()
    {
        WriteString();
        CompareFiles();
    }

    // Update is called once per frame
    void Update()
    {

    }
    public static void WriteString()
    {
        string path = Path.GetFullPath("./");
        int pom = 0;
        string actual_path = "";
        string what_to_write = "";

        /* Uzimam relative fajl path fajla u kome je smestena igrica, uzimam samo prvi "nivo" fajla */
        char[] main_path = path.ToCharArray();
        for (int i = 0; i < main_path.Length; i++)
        {
            if ((int)main_path[i] == 92)
            {
                pom++;
                if (pom == 2)
                {
                    base_file_path = string.Copy(actual_path);
                    break;
                }
            }
            actual_path = actual_path.Insert(i, main_path[i].ToString());         
        }



        /* Citam los fajl i upisujem contents u what_to_write */
        string bad_path = Path.GetFullPath("./") + "/Template/Bad/roomBad.txt";
        StreamReader reader = new StreamReader(bad_path);
        what_to_write = reader.ReadToEnd();
        reader.Close();

        /* Citam fajl koji player treba da eddituje, sadrzaj fajla pisem u check*/
        string check = "";
        string path_check = base_file_path + "/room.txt";
        StreamReader reader_check = new StreamReader(path_check);
        check = reader_check.ReadToEnd();
        reader_check.Close();

        /* Testiram da l je fajl koji player treba da eddituje prazan, ako jeste upisujem ono sto treba da se eddituje*/
        if (check.Length == 0) {
            StreamWriter writer = new StreamWriter(actual_path + "/room.txt", true);
            writer.WriteLine(what_to_write);
            writer.Close();
        }
      
    }


    public static void CompareFiles()
    {
        string room_good = "";
        string room_user = "";


        string path = base_file_path + "/room.txt";
        StreamReader reader = new StreamReader(path);
        room_user = reader.ReadToEnd();
        reader.Close();

        string path_good = Path.GetFullPath("./") + "/Template/roomGood.txt";
        StreamReader reader_good = new StreamReader(path_good);
        room_good = reader_good.ReadToEnd();
        reader_good.Close();

        if (room_user.Equals(room_good))
        {
            Debug.Log(" BOG NIJE MRTAV!!!!!!!!!!!!! (i ova 2 fajla su ista) ");
        }
        else
        {
            Debug.Log("bog je mrtav :(");
        }
    }
}


   
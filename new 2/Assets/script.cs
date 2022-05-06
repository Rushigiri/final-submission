using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Linq;

public class script : MonoBehaviour
{
    public int size;
    public string StartingLetter;
    // Start is called before the first frame update
    void Start()
    {
       
        string p = "C:/words.txt";
        List<string> data = File.ReadAllLines(p).ToList();
        string p1 = "C:/Users/Rushi/output file.txt";
        using (FileStream f = new FileStream(p1, FileMode.Append, FileAccess.Write))
        {
            using (StreamWriter w = new StreamWriter(f))
            {
                foreach (var v in data)
                {
                    if (v.Length == size && v.Substring(0, 1).Equals(StartingLetter))
                    {
                        w.WriteLine(v);
                    }

                }
            }
        }
    }

   
}

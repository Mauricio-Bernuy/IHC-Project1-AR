
// using System.IO;

// public class scoreFile
// {
//     private int[] level;
//     private bool[] completed;
//     private float[] completionTime;

//     private string[] scores;

//     private string fileName;


//     //This class stores information for each of the levels.
//     public scoreFile(int num)
//     {
//         private string fileName = Application.persistentDataPath + "/inventory.txt";
       

//         try
//         {

//             if (!File.Exists(fileName))
//             {

//                 level = new int[num];
//                 completionTime = new float[num];
//                 completed = new bool[num];
//                 scores = new string[num];

//                 Debug.Log("Opened file!");

//                 for (int i = 0; i < num; i++)
//                 {
//                     level = i + 1;
//                     completionTime = 0;
//                     completed = false;

//                     scores = level + " " + 0 + " " + completionTime;
//                 }

//                 Debug.Log(“About to write into file!”);
//                 File.WriteAllLines(fileName, scores);
//             }

//             else
//             {
//                 Debug.Log(“File is exist! Loading!”);
//                 loadFile();
//             }
//         }

//         catch (System.Exception e)
//         {
//             Debug.Log(e);
//         }
//     }

//     public bool isComplete(int i) { return completed; }
//     public int levels(int i) { return level[i - 1] + 1; }
//     public float timeScore(int i) { return completionTime; }

//     public void loadFile()
//     {
//         Debug.Log("Reading");
//         string[] levelsInfo = File.ReadAllLines(fileName);

//         int num = levelsInfo.Length;

//         level = new int[num];
//         completionTime = new float[num];
//         completed = new bool[num];

//         for (int i = 0; i < num; i++)
//         {
//             //Debug.Log(levelsInfo);
//             string str = levelsInfo;
//             level = (int)int.Parse(str.Substring(0, 1));
//             int f = int.Parse(str.Substring(2, 1));
//             if (f == 0)
//                 completed = false;
//             else
//                 completed = true;
//             completionTime = (float)float.Parse(str.Substring(4));
//             }
//     }
// }
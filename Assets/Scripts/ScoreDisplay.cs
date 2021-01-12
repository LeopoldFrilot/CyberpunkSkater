using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.IO;

public class ScoreDisplay : MonoBehaviour
{
    public TextMeshProUGUI HighScoreDisplay;

    public int thisRoundScore;
    public int maxHighScores;

    private string path;
    private StreamWriter SW;
    private StreamReader SR;
    private FileStream stream;

    public List<string[]> scoresList;

    // Start is called before the first frame update
    void Start()
    {
        thisRoundScore = Mathf.RoundToInt(Statics.score);
        GetComponent<TextMeshProUGUI>().text = "Score: " + thisRoundScore;

        UpdateFile();
    }
    
    private void UpdateFile()
    {
        path = Path.Combine(Application.streamingAssetsPath, "HighScores.txt");
        scoresList = new List<string[]>();
        if(File.Exists(path))
        {
            stream = File.Open(path, FileMode.Open);
            SR = new StreamReader(stream);
            
            string lineRead = SR.ReadLine();
            while (lineRead != null) // Reading
            {
                
                var values = lineRead.Split('~');
                string[] line = new string[2];
                line[0] = values[0];
                line[1] = values[1];
                scoresList.Add(line);
                lineRead = SR.ReadLine();
            }

            bool found = false;
            for(int i = 0; i < scoresList.Count; i++)
            {
                if(int.Parse(scoresList[i][0]) < thisRoundScore)
                {
                    InsertIntoScoresList(i);
                    found = true;
                    break;
                }
            }
            if(!found)
            {
                InsertIntoScoresList(-1);
            }
            if (scoresList.Count > maxHighScores)
            {
                scoresList.RemoveAt(scoresList.Count - 1);
            }
            SR.Close();
            stream.Close();
        }
        else
        {
            InsertIntoScoresList(0);
        }
        stream = File.Open(path, FileMode.Create);

        SW = new StreamWriter(stream);
        string output = "Score               Date\n\n";
        string fileOutput = "";
        for(int i = 0; i < scoresList.Count; i++)
        {
            int num = i + 1;
            output += "\n" + num + ": " + scoresList[i][0] + "        " + scoresList[i][1];
            fileOutput += scoresList[i][0] + '~' + scoresList[i][1] + "\n";
        }
        SW.Write(fileOutput);
        HighScoreDisplay.text = output;

        SW.Close();
        stream.Close();
    }
    private void InsertIntoScoresList(int index)
    {
        string[] line = new string[2];
        line[0] = thisRoundScore.ToString();
        line[1] = System.DateTime.Now.ToString();
        if (index == -1)
        {
            scoresList.Add(line);
        }
        else
        {
            scoresList.Insert(index, line);
        }
    }
}

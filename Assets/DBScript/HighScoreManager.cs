using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.Data;
using Mono.Data.Sqlite;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class HighScoreManager : MonoBehaviour
{

    private string connectionString;
    private List<HighScore> highScores = new List<HighScore>();
    public GameObject scorePrefab;
    public Transform scoreParent;
    public int hCount;
    // Use this for initialization
    void Start()
    {
        connectionString = "URI=file:" + Application.dataPath + "/HighScoreDB.sqlite";
       
        //GetScores();
        //UpdateData("HighScores",  "PlayerID", 9 ,"Score", 2000);
        ShowScores();
      
    }

    // Update is called once per frame
    void Update()
    {
     
    }



    private void GetScores()
    {
        highScores.Clear();
        using (IDbConnection dbConnection = new SqliteConnection(connectionString))
        {
            dbConnection.Open();

            using (IDbCommand dbCmd = dbConnection.CreateCommand())
            {
                string sqlQuery = "SELECT * FROM HighScores";
                dbCmd.CommandText = sqlQuery;

                using (IDataReader reader = dbCmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        highScores.Add(new HighScore(reader.GetInt32(0), reader.GetInt32(2), reader.GetString(1), reader.GetInt32(4), reader.GetDateTime(3)));

                    }

                    dbConnection.Close();
                    reader.Close();
                }

            }

            hCount = highScores.Count;
        }

        highScores.Sort();

    }

    private void DeleteScore(int id)
    {
        using (IDbConnection dbConnection = new SqliteConnection(connectionString))
        {
            dbConnection.Open();

            using (IDbCommand dbCmd = dbConnection.CreateCommand())
            {
                string sqlQuery = String.Format("DELETE FROM HighScores WHERE PlayerID = (\"{0}\")", id);
                dbCmd.CommandText = sqlQuery;
                dbCmd.ExecuteScalar();
                dbConnection.Close();

            }

        }

    }
 

    private void ShowScores()
    {
        GetScores();
        
        for (int i = 0; i < highScores.Count; i++)
        {
            GameObject tmpObjec = Instantiate(scorePrefab);
            HighScore tmpScore = highScores[i];         
            tmpObjec.GetComponent<HighScoreScript>().SetScore(tmpScore.Name, tmpScore.Score.ToString() ,"#" + (i + 1).ToString(),tmpScore.Diamond.ToString());
            tmpObjec.transform.SetParent(scoreParent);
            tmpObjec.GetComponent<RectTransform>().localScale = new Vector3(1, 1, 1);
        }
        Debug.Log(highScores.Count);
    }

    public int HsCount()
    {        
        GetScores();       
        return hCount;
    }
  
}

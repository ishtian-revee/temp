using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.Data;
using Mono.Data.Sqlite;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class GetPreviousScore : MonoBehaviour
{
    private string connectionString;
    public int prevScore;

    // Use this for initialization
    void Start()
    {
        connectionString = "URI=file:" + Application.dataPath + "/HighScoreDB.sqlite";
    }

    public void GetPrevScore(int id)
    {
        using (IDbConnection dbConnection = new SqliteConnection(connectionString))
        {
            dbConnection.Open();

            using (IDbCommand dbCmd = dbConnection.CreateCommand())
            {
                string sqlQuery = String.Format("SELECT Score FROM HighScores WHERE PlayerID = (\"{0}\")", id);
                dbCmd.CommandText = sqlQuery;

                using (IDataReader reader = dbCmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        prevScore = reader.GetInt32(0);
                    }

                    dbConnection.Close();
                    reader.Close();
                }
            }
        }
    }
}

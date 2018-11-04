using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Mono.Data.Sqlite;
using System.Data;

public class InsertName : MonoBehaviour {

    public Text enterName;
    private string connectionString;

    public void enter()
    {
        InsertScore(enterName.text, 0 , 0);
        Debug.Log("Success");
    }

    void Start()
    {
        connectionString = "URI=file:" + Application.dataPath + "/HighScoreDB.sqlite";
    }
 
    public void InsertScore(string name, int newScore , int diamonds)
    {
        using (IDbConnection dbConnection = new SqliteConnection(connectionString))
        {
            dbConnection.Open();

            using (IDbCommand dbCmd = dbConnection.CreateCommand())
            {
                string sqlQuery = string.Format("INSERT into HighScores(Name,Score,Diamonds) VALUES (\"{0}\",\"{1}\",\"{2}\")", name, newScore ,diamonds);
                dbCmd.CommandText = sqlQuery;
                dbCmd.ExecuteScalar();
                dbConnection.Close();

            }

        }

    }

    
}

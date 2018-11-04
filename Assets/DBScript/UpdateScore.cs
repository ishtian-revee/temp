using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.Data;
using Mono.Data.Sqlite;
using UnityEngine.SceneManagement;

public class UpdateScore : MonoBehaviour
{

    public GetScoreData ab;
    private string connectionString;
    public int x;


    // Use this for initialization
    void Start()
    {
        connectionString = "URI=file:" + Application.dataPath + "/HighScoreDB.sqlite";

        x = ab.HsCount();

    }

    public void UpdateData(string tableName, string whereHeader, object whereValue, string setHeader, object setValue)
    {
        using (var dbConnection = new SqliteConnection(connectionString))
        {
            dbConnection.Open();

            using (var dbCommand = dbConnection.CreateCommand())
            {

                dbCommand.CommandText = string.Format("UPDATE {0} " +
                                                       "SET {1} = @setValue " +
                                                       "WHERE {2} = @whereValue",
                    tableName, setHeader, whereHeader);

                SqliteParameter setParam = new SqliteParameter("@setValue", setValue);
                SqliteParameter whereParam = new SqliteParameter("@whereValue", whereValue);

                dbCommand.Parameters.Add(setParam);
                dbCommand.Parameters.Add(whereParam);

                Debug.Log(dbCommand.CommandText);

                dbCommand.ExecuteNonQuery();
            }
        }
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mono.Data.Sqlite;
using System.Data;
using System;



public class Database : MonoBehaviour {


    

    void Start () {
        
        string conn = "URI=file:" + Application.dataPath + "/Plugins/Users.s3db";
        IDbConnection dbconn;
        dbconn = (IDbConnection)new SqliteConnection(conn);
        dbconn.Open(); //Open connection to the database.
        IDbCommand dbcmd = dbconn.CreateCommand();
        string sqlQuery = "SELECT id, Voornaam, Achternaam, Klas FROM Usersinfo";/*"SELECT value,name, randomSequence " + "FROM Usersinfo";*/
        dbcmd.CommandText = sqlQuery;
        IDataReader reader = dbcmd.ExecuteReader();
        while (reader.Read())
        {
            int id = reader.GetInt32(0);
            string Voornaam = reader.GetString(1);
            string Achternaam = reader.GetString(2);
            int Klas = reader.GetInt32(3);
            Debug.Log("value = " + id + "Voornaam = " + Voornaam + "  achternaam = " + Achternaam + "  klas = " + Klas);
        }
        reader.Close();
        reader = null;
        dbcmd.Dispose();
        dbcmd = null;
        dbconn.Close();
        dbconn = null;
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public class PlayerData
{
    private class SavePlayer
    {
        public Vector3 position;
        public Vector3 destination;
    }
    static SavePlayer save = new();
    public static Vector3 position
    {
        get{ return save.position;}
        set{ save.position = value;}
    }
    public static Vector3 destination 
    { 
        get{ return save.destination;} 
        set{ save.destination = value;}
    }
    public const string PLAYER_PATH ="playerData.dat";
    public static string SAVE_PATH { get{ return $"{Application.persistentDataPath}//{PLAYER_PATH}";}}

    public static void Save()
    {
        BinaryFormatter bf = new();
        FileStream file = File.Create(SAVE_PATH);
        SavePlayer sp = new();
        sp.position = position;
        sp.destination = destination;
        bf.Serialize(file, sp);
        file.Close();
        Debug.Log($"Moves save at {SAVE_PATH}");
    }
}

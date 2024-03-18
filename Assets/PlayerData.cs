using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using TMPro;
using UnityEngine;
using static UnityEditor.Experimental.GraphView.GraphView;

[Serializable]
public class PlayerD {

    public string playerName;
    public int highscore;

}

public class PlayerData : MonoBehaviour
{

    public PlayerD playerD;

    public static PlayerData Instance;

    public string playerName;

    public TMP_InputField inputField;

    public TMP_Text scoreTxt;

    private void Awake()
    {
        if(Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);

        LoadData();
    }

    private void Start()
    {
        SaveData();

        //SaveScore(0);
    }

    public void LoadData()
    {
        string path = Application.persistentDataPath + "/savefile.json";
        if(File.Exists(path))
        {
            string json = File.ReadAllText(path);
            PlayerD data = JsonUtility.FromJson<PlayerD>(json);
            playerName = data.playerName;
            playerD.playerName = data.playerName;
            playerD.highscore = data.highscore;
            scoreTxt.text = data.highscore.ToString();
        }
        else
        {
            Debug.Log("No Data");
        }
    }

    public void SaveData()
    {
        PlayerD data = new PlayerD();
        data.playerName = inputField.text;
        string json = JsonUtility.ToJson(data);
        File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);
    }

    public void SaveScore(int score)
    {
        PlayerD data = new PlayerD();
        data.playerName = inputField.text;
        data.highscore = score;
        string json = JsonUtility.ToJson(data);
        File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);
    }

}

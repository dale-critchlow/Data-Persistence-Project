using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UpdateData : MonoBehaviour {
    public Text dataTxt;

    public Text currentUserText;

    void Awake()
    {
        UpdateBestScore();
        currentUserText.text = PlayerData.Instance.playerName;
        //Best Score : Name : 0
    }

    public void UpdateBestScore()
    {
        dataTxt.text = "Best Score : " + PlayerData.Instance.playerD.highscore.ToString() + " Name : " + PlayerData.Instance.playerD.playerName.ToString();
    }

}
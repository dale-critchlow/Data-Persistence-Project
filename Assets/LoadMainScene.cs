using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadMainScene : MonoBehaviour
{

    public Button loadSceneBtn;

    private void Awake()
    {
        loadSceneBtn.onClick.AddListener(LoadScene);
    }

    void LoadScene()
    {
        Debug.Log("Loading Scene.");
        PlayerData.Instance.SaveData();
        SceneManager.LoadScene(1);
    }

}

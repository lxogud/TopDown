using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartBtn : MonoBehaviour
{
    public InputField playerNameInput;
    public string playerName;

    public void StartGame()
    {
        playerName = playerNameInput.text;

        if (!string.IsNullOrEmpty(playerName))
        {
            PlayerPrefs.SetString("playerName", playerName);

            SceneManager.LoadScene("MainScene");
        }
        else
        {
            Debug.Log("닉네임을 입력하세요..");
        }
    }
}

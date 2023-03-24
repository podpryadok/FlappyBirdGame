using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartGameLogicScript : MonoBehaviour
{
    public Button startButton;

    private void Start()
    {
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            startButton.Select();
        }
    }

    public void StartGame()
    {
        SceneManager.LoadScene("GameScene");
    }
}

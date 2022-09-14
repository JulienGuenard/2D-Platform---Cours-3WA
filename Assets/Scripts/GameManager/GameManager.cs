using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    static public GameManager instance;

    public float winRestartTime;

    public GameObject winCanvas;
    public GameObject loseCanvas;

    bool isWin = false;
    bool isLose = false;

    void Awake()
    {
        if (instance == null) { instance = this; }
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.R)) Restart();
    }

    public void Win()
    {
        if (isWin) return;

        isWin = true;
        winCanvas.SetActive(true);
        StartCoroutine(WinRestart());
    }

    public void Lose()
    {
        if (isLose) return;

        isLose = true;
        loseCanvas.SetActive(true);
        StartCoroutine(WinRestart());
    }

    IEnumerator WinRestart()
    {
        yield return new WaitForSeconds(winRestartTime);
        Restart();
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}

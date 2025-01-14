﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    int currentSceneIndex;

    // Start is called before the first frame update
    void Start()
    {
        currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
    }

    private void Update()
    {
        //Debug.Log(SceneManager.sceneCountInBuildSettings);
        //Debug.Log("current scene is " + currentSceneIndex);
        if ((currentSceneIndex == 0) && Input.GetButtonDown("JumpPlayer1"))
        {
            LoadNextScene();
        }
        else if ((currentSceneIndex == 0  || currentSceneIndex == SceneManager.sceneCountInBuildSettings - 1) && Input.GetButtonDown("UseItemPlayer1"))
        {
            Application.Quit();
        }else if(currentSceneIndex == SceneManager.sceneCountInBuildSettings - 1 && Input.GetButtonDown("JumpPlayer1"))
        {

            LoadMainMenu();
        }
    }

    public void RestartScene()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(currentSceneIndex);
    }

    public void LoadMainMenu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Start Screen");
    }

    public void LoadYouLose()
    {
        SceneManager.LoadScene("Game Over");
    }

    /*IEnumerator WaitForTime()
    {
        yield return new WaitForSeconds(timeToWait);
        LoadNextScene();
    }*/

    public void LoadNextScene()
    {
        SceneManager.LoadScene(currentSceneIndex + 1);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

}

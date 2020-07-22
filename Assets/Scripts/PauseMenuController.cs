﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseMenuController : MonoBehaviour
{
    public GameObject pauseMenu;
    public GameObject cirno;
    public GameObject alice;
    public GameObject chen;
    public GameObject flandre;
    public GameObject marisa;
    public GameObject patchouli;
    public GameObject ran;
    public GameObject reimu;

    private bool gamePaused;
    private SpawnFumo mySpawnFumo;

    // Start is called before the first frame update
    void Start()
    {
        mySpawnFumo = FindObjectOfType<SpawnFumo>();
        Resume();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            switch (gamePaused)
            {
                case true:
                    Resume();
                    break;
                case false:
                    Pause();
                    break;
            }
        }
    }

    public void Resume()
    {
        Time.timeScale = 1f;
        pauseMenu.SetActive(false);
        gamePaused = false;
    }

    public void Pause()
    {
        Time.timeScale = 0f;
        pauseMenu.SetActive(true);
        gamePaused = true;
    }

    public void SelectFumo(int selection)
    {
        switch (selection)
        {
            case 0:
                mySpawnFumo.fumoToSpawn = cirno;
                break;
            case 1:
                mySpawnFumo.fumoToSpawn = alice;
                break;
            case 2:
                mySpawnFumo.fumoToSpawn = chen;
                break;
            case 3:
                mySpawnFumo.fumoToSpawn = flandre;
                break;
            case 4:
                mySpawnFumo.fumoToSpawn = marisa;
                break;
            case 5:
                mySpawnFumo.fumoToSpawn = patchouli;
                break;
            case 6:
                mySpawnFumo.fumoToSpawn = ran;
                break;
            case 7:
                mySpawnFumo.fumoToSpawn = reimu;
                break;
        }
    }
}

﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    
    public void OnPlay()
    {
        SceneManager.LoadScene("Level1");
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

        //if (Input.GetKeyDown(KeyCode.Space))
        //{
        //    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        //}
    } 
   

}

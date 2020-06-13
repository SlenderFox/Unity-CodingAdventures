﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseApp : MonoBehaviour
{
    [SerializeField, Tooltip("Button will automatically close the game")]
    private KeyCode m_kcQuitButton = KeyCode.End;

    public static void Quit()
    {
        #if UNITY_STANDALONE
            Application.Quit();
        #endif

        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
        #endif
    }

    /// <summary>
    /// Called once per frame
    /// </summary>
    private void Update()
    {
        // Quit button
        if (Input.GetKeyDown(m_kcQuitButton))
        {
            Quit();
        }
    }
}
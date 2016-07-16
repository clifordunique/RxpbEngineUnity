﻿using System;
using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;



/// <summary>
/// Loading Scene 관리자입니다.
/// </summary>
public class LoadingSceneManager : MonoBehaviour
{
    #region Unity에서 접근 가능한 공용 필드를 정의합니다.
    /// <summary>
    /// 페이드 인/아웃 효과 관리자입니다.
    /// </summary>
    public ScreenFader fader;


    #endregion



    #region 필드를 정의합니다.
    bool fadeRequested = false;

    static bool loadRequested = false;
    static string loadingLevelName = null;


    #endregion



    #region MonoBehaviour 기본 메서드를 재정의합니다.
    /// <summary>
    /// MonoBehaviour 개체를 초기화합니다.
    /// </summary>
    void Start()
    {
        // 페이드인 효과를 추가합니다.
        fader.FadeIn();
    }
    /// <summary>
    /// 프레임이 갱신될 때 MonoBehaviour 개체 정보를 업데이트 합니다.
    /// </summary>
    void Update()
    {
        // 불러오기 요청이 확인되면
        if (loadRequested)
        {
            // 불러오기 코루틴을 시작합니다.
            StartCoroutine(LoadMain());

            // 확인된 요청에 대한 스위치를 닫습니다.
            loadRequested = false;
        }
    }


    #endregion



    #region 메서드를 정의합니다.
    /// <summary>
    /// 불러오기 코루틴입니다.
    /// </summary>
    /// <returns>불러오기 코루틴 반복자입니다.</returns>
    IEnumerator LoadMain()
    {
        // 비동기 불러오기를 시작합니다.
        AsyncOperation async = SceneManager.LoadSceneAsync(loadingLevelName);

        // 비동기 불러오기가 완료될 때까지 fader의 동작을 관리합니다.
        while (async.isDone == false)
        {
            if (async.progress >= 0.8f)
            {
                if (fadeRequested == false)
                {
                    if (fader != null)
                    {
                        fader.FadeOut();
                    }
                    fadeRequested = true;
                }
            }
            yield return true;
        }

        // 
        async.allowSceneActivation = true;
    }

    /// <summary>
    /// 장면을 불러옵니다.
    /// </summary>
    /// <param name="levelName">불러올 장면의 이름입니다.</param>
    public static void LoadLevel(string levelName)
    {
        loadingLevelName = levelName;
        loadRequested = true;

        // 구형 정의를 새로운 정의로 업데이트 합니다.
        SceneManager.LoadScene("Loading"); // Application.LoadLevel("Loading");
    }


    #endregion
}
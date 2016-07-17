﻿using System;
using UnityEngine;
using System.Collections;



/// <summary>
/// Scene 데이터베이스입니다.
/// </summary>
public class DataBase : MonoBehaviour
{
    #region Unity에서 접근 가능한 공용 필드를 정의합니다.
    public PlayerController _playerX;
    public PlayerController _playerZ;


    public PhysicsMaterial2D _frictionlessWall;
    public CameraZoneParent _cameraZoneParent;


    public NewMap _map;


    public CameraFollowScript _cameraFollow;


    public StageManager _stageManager;


    #endregion










    #region 필드를 정의합니다.


    #endregion










    #region 프로퍼티를 정의합니다.
    public PlayerController PlayerX { get { return _playerX; } }
    public PlayerController PlayerZ { get { return _playerZ; } }


    public PhysicsMaterial2D FrictionlessWall
    {
        get { return _frictionlessWall; }
    }
    public CameraZoneParent CameraZoneParent
    {
        get { return _cameraZoneParent; }
    }


    public NewMap Map
    {
        get { return _map; }
    }


    public CameraFollowScript CameraFollow
    {
        get { return _cameraFollow; }
    }


    public StageManager StageManager
    {
        get { return _stageManager; }
    }


    #endregion










    #region MonoBehaviour 기본 메서드를 재정의합니다.
    /// <summary>
    /// MonoBehaviour 개체를 초기화합니다.
    /// </summary>
    void Start()
    {

    }
    /// <summary>
    /// 프레임이 갱신될 때 MonoBehaviour 개체 정보를 업데이트 합니다.
    /// </summary>
    void Update()
    {

    }


    #endregion










    #region 메서드를 정의합니다.


    #endregion










    #region 구형 정의를 보관합니다.
    [Obsolete("구형 정의 테스트입니다.")]
    /// <summary>
    /// 구형 정의 테스트 함수입니다.
    /// </summary>
    void Function()
    {
        Console.WriteLine("Hello, world!");
    }


    #endregion
}

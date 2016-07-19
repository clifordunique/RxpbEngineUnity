﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



[Serializable]
/// <summary>
/// 게임 데이터입니다.
/// </summary>
public class GameData
{
    #region 필드를 정의합니다.
    /// <summary>
    /// 엑스의 최대 체력입니다.
    /// </summary>
    int _maxHealthX = 20;
    /// <summary>
    /// 제로의 최대 체력입니다.
    /// </summary>
    int _maxHealthZ = 20;


    /// <summary>
    /// 맵 상태 집합입니다.
    /// </summary>
    GameMapStatus[] _mapStatuses = new GameMapStatus[8];


    #endregion



    #region 프로퍼티를 정의합니다.
    /// <summary>
    /// 엑스의 최대 체력입니다.
    /// </summary>
    public int MaxHealthX
    {
        get { return _maxHealthX; }
        set { _maxHealthX = value; }
    }
    /// <summary>
    /// 제로의 최대 체력입니다.
    /// </summary>
    public int MaxHealthZ
    {
        get { return _maxHealthZ; }
        set { _maxHealthZ = value; }
    }


    /// <summary>
    /// 맵 상태 집합입니다.
    /// </summary>
    public GameMapStatus[] MapStatuses { get { return _mapStatuses; } }


    #endregion
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class StageDate : ScriptableObject
{

    [SerializeField]
    private Vector2 limitMin;
    [SerializeField]
    private Vector2 limitMax;

    public Vector2 LimitMin => limitMin;
    public Vector2 LimitMax => limitMax;

}

/*
 * File : StageDate.cs
 * Desc
 *  : 현재 스테이지의 화면 내 범위
 *  : 에셋 데이터로 저장해두고 정보를 불러서 사용
 *   
 */
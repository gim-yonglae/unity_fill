using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Metworite : MonoBehaviour
{
    [SerializeField]
    private int damage = 5; //운석 공격력
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // 운석에 부딪힌 오브젝트의 태그가 "Playe"이면  
        if (collision.CompareTag("Player"))
        {
            // 운석 공격력만큼 플레이어 체력감소
            collision.GetComponent<PlayerHP>().TakeDamage(damage);
            // 운석 사망
            Destroy(gameObject);
        }
    }
}
/*
 * File : Metworite.cs
 * Desc
 *  : 운석 오브젝트에 부착해서 사용
 *  
 * Functions
 * 
 */
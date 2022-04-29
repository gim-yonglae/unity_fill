using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playt : MonoBehaviour
{
    [SerializeField]
    private StageDate stageDate;
    [SerializeField]
    private KeyCode keyCodeAttack = KeyCode.Space;
    private MoveSpeed2D movespeed2D;
    private Weapon weapon;

    private void Awake()
    {
        movespeed2D = GetComponent<MoveSpeed2D>();
        weapon = GetComponent<Weapon>();
    }
    void Update()
    {
        //방향 키를 눌러 이동 방향 설정
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");

        // 공격 키를 Down/Up으로 공격 시작/종료
        movespeed2D.MoveTo(new Vector3(x, y, 0));
        if (Input.GetKeyDown(keyCodeAttack))
        {
            weapon.StartFiring();
        }
        else if (Input.GetKeyUp(keyCodeAttack))
        {
            weapon.StopFiring();
        }
    }
    private void LateUpdate()
    {
        // 플레이어 캐릭터가 화면 범위 바깥으로 나가지 못하도록 함
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, stageDate.LimitMin.x, stageDate.LimitMax.x),
                                         Mathf.Clamp(transform.position.y, stageDate.LimitMin.y, stageDate.LimitMax.y));
    }
}

/*
 * File : Playt.cs 
 * Desc
 *  : 플레이어 캐릭터에 부착해서 사용
 * 
 * Functions
 *
 */
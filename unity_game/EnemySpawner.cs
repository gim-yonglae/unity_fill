using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField]
    private StageDate stageDate; // 적 생성을 위한 스테이지 크기 정보
    [SerializeField]
    private GameObject enemyPrefab; // 복제해서 생성할 적 캐릭터 플팹
    [SerializeField]
    private float spawnTime; //생성 주기

    private void Awake()
    {
        StartCoroutine("SpawnEnemy");
    }

    private IEnumerator SpawnEnemy()
    {
        while (true)
        {
            // x 위치는 스테이지의 크기 범위 내에서 임의의 값을 선택
            float positionx = Random.Range(stageDate.LimitMin.x, stageDate.LimitMax.x);
            // 적 캐릭터 생성
            Instantiate(enemyPrefab, new Vector3(positionx, stageDate.LimitMax.y + 1.0f, 0.0f), Quaternion.identity);
            //spawnTime만큼 대기
            yield return new WaitForSeconds(spawnTime);
        }

    }
}
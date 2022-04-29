using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MetworiteSpawner : MonoBehaviour
{
    [SerializeField]
    private StageDate stageDate;
    [SerializeField]
    private GameObject alerLinePrefab;
    [SerializeField]
    private GameObject meteoritePrefab;
    [SerializeField]
    private float minSpawnerTime = 1.0f;
    [SerializeField]
    private float maxSpawnerTime = 4.0f;

    private void Awake()
    {
        StartCoroutine("SpawnMeteorite");
    }

    private IEnumerator SpawnMeteorite()
    {
        while (true)
        {
            // x 위치는 스테이지의 크기 범위 내에서 임의의 값을 선택
            float positionx = Random.Range(stageDate.LimitMin.x, stageDate.LimitMax.x);
            // 경고선 오브젝트 생성
            GameObject alerLineClone = Instantiate(alerLinePrefab, new Vector3(positionx, 0, 0), Quaternion.identity);
            
            // 1초간 대기
            yield return new WaitForSeconds(1.0f);

            // 경고선 오브젝트 생성
            Destroy(alerLineClone);
            
            //메테오 오브젝트 생성
            Vector3 metoritoPosition = new Vector3(positionx, stageDate.LimitMax.y + 1.0f, 0);
            Instantiate(meteoritePrefab, metoritoPosition, Quaternion.identity);

            // 대기 시간 설정 minSpawnerTime ~ maxSpawnerTime
            float spawnTime = Random.Range(minSpawnerTime, maxSpawnerTime);
            // 해당 사간만큼 대기 후 다음 로직 실행
            yield return new WaitForSeconds(spawnTime);


        }
    }
}
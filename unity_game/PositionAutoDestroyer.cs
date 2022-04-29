using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionAutoDestroyer : MonoBehaviour
{
    [SerializeField]
    private StageDate stageDate;
    private float destoyWeight = 2.0f;

    private void LateUpdate()
    {
        if(transform.position.y < stageDate.LimitMin.y - destoyWeight ||
           transform.position.y > stageDate.LimitMax.y + destoyWeight ||
           transform.position.x < stageDate.LimitMin.x - destoyWeight ||
           transform.position.x > stageDate.LimitMax.x + destoyWeight)
        {
            Destroy(gameObject);
        }
    }
}
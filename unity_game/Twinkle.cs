using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Twinkle : MonoBehaviour
{
    private float fadeTime = 0.1f;
    private SpriteRenderer spriteRenderer;

    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();

        StartCoroutine("TwinkleLoop");
    }

    private IEnumerator TwinkleLoop()
    {
        while (true)
        {
            // Alpha 값을 1에서 0으로 : Fade Out
            yield return StartCoroutine(FadeEffect(1, 0));
            // Alpha 값을 0에서 1으로 : Fade In
            yield return StartCoroutine(FadeEffect(0, 1));
        }
    } 

    private IEnumerator FadeEffect(float start, float end)
    {
        float currebtTime = 0.0f;
        float percant = 0.0f;

        while (percant < 1)
        {
            // fadeTime 시간동한 while() 반목문 실행
            currebtTime += Time.deltaTime;
            percant = currebtTime / fadeTime;

            //유니티 클래스에서 설정되어 있는 spriteRenderer.color, transform.position은 프로퍼티로
            //spriteRenderer.color.a = 1.0f과 같은 설정이 불가능하다
            //spriteRenderer.color = new Color(spriteRenderer.color.r, .. , .. ,1.0f);과 같이 설정해야 한다
            Color color = spriteRenderer.color;
            color.a = Mathf.Lerp(start, end, percant);
            spriteRenderer.color = color;

            yield return null;
        }
    }
}

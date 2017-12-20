using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Code used from Sloan Kelly's tut series on card games, credit to him
public class CardFlipper : MonoBehaviour
{
    public AnimationCurve scaleCurve;
    public float duration = 0.5f;

    private CardModel cModel;
    private SpriteRenderer spRenderer;

    void Awake()
    {
        spRenderer = GetComponent<SpriteRenderer>();
        cModel = GetComponent<CardModel>();
    }

    public void flipCard(Sprite startImage, Sprite endImage, int cardIndex)
    {
        StopCoroutine(Flip(startImage, endImage, cardIndex));
        StartCoroutine(Flip(startImage, endImage, cardIndex));
    }

    IEnumerator Flip(Sprite startImage, Sprite endImage, int cardIndex)
    {
        spRenderer.sprite = startImage;
        float time = 0.0f;
        while (time <= 1.0f)
        {
            float scale = scaleCurve.Evaluate(time);
            time = time + Time.deltaTime / duration;

            Vector3 localScale = transform.localScale;
            localScale.x = scale;
            transform.localScale = localScale;

            if(time >= 0.5f)
            {
                spRenderer.sprite = endImage;
            }

            yield return new WaitForFixedUpdate();
        }

        if (cardIndex == -1)
        {
            cModel.toggleFace(false);
        }
        else
        {
            cModel.cardIndex = cardIndex;
            cModel.toggleFace(true);
        }
    }
}

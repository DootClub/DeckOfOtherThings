using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteFlip : MonoBehaviour
{
    private SpriteRenderer SelfSprite;
    private Transform SelfTransform;
    private Vector3 SelfPosition;
    private Vector3 EchoPosition;

    public void FlipCheck()
    {
        SelfPosition = SelfTransform.position;
        if (SelfSprite.flipX)
        {
            if (SelfPosition.x < EchoPosition.x)
            {
                SelfSprite.flipX = false;
            }
        }
        else
        {
            if (SelfPosition.x > EchoPosition.x)
            {
                SelfSprite.flipX = true;
            }
        }
        EchoPosition = SelfPosition;
    }

    // Use this for initialization
    void Start()
    {
        SelfSprite = GetComponent<SpriteRenderer>();
        SelfTransform = GetComponent<Transform>();
        SelfPosition = SelfTransform.position;
        EchoPosition = SelfTransform.position;
    }

    // Update is called once per frame
    void Update()
    {
        FlipCheck();
    }
}

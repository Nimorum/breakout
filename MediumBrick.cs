using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MediumBrick : Brick
{
    [SerializeField]
    Sprite dmgSprite;
    public override void Hit()
    {
        base.Hit();
        if (life <= 25)
        {
            GetComponent<SpriteRenderer>().sprite = dmgSprite;
        }
    }
}

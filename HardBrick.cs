using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HardBrick : Brick
{
    [SerializeField]
    Sprite[] dmgSprites;
    public override void Hit()
    {
        base.Hit();
        if (life <= 25)
        {
            GetComponent<SpriteRenderer>().sprite = dmgSprites[0];
        }else if (life <= 50)
        {
            GetComponent<SpriteRenderer>().sprite = dmgSprites[1];
        }
    }
}

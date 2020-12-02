using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Brick : MonoBehaviour
{
    [SerializeField]
    public int life;
    [SerializeField]
    public int points;

    public virtual void Hit()
    {
        life -= 25;
        if (life <= 0)
        {
            Die();
        }
    }

    public virtual void Die()
    {
        //send points to the controller
        GameController.instance.AddPoints(points);
        //remove bricks from controller
        GameController.instance.RemoveBrickFromList(this.gameObject);
        //destroy game object
        GameObject.Destroy(this.gameObject);
    }
}

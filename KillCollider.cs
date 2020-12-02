using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillCollider : MonoBehaviour
{
    public void Hit()
    {
        GameController.instance.PlayerDie();
    }
}

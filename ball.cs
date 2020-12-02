using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
    private void OnParticleCollision(GameObject other)
    {
        other.SendMessage("Hit", null, SendMessageOptions.DontRequireReceiver);
    }
}

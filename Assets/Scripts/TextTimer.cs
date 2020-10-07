using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextTimer : MonoBehaviour
{
    public float time = 4f;

    void Start()
    {
        Destroy(gameObject, time);
    }
}

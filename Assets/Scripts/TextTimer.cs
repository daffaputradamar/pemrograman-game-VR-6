using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextTimer : MonoBehaviour
{
    public float time = 4; //Seconds to read the text

    void Start()
    {
        Destroy(gameObject, time);
    }
}

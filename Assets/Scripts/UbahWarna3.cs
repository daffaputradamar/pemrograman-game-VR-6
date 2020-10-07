using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UbahWarna3 : MonoBehaviour
{
    public void Merah()
    {
        GetComponent<Renderer>().material.color = Color.red;
    }

    public void Biru()
    {
        GetComponent<Renderer>().material.color = Color.blue;
    }

    public void Hitam()
    {
        GetComponent<Renderer>().material.color = Color.black;
    }
}

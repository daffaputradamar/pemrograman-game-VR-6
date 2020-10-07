using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TangkapObject : MonoBehaviour
{
    public GameObject bola;
    public GameObject tangan;
    public GameObject telapak;
    bool tertangkap;
    public Vector3 posisiBola;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            if (!tertangkap)
            {
                bola.transform.SetParent(tangan.transform);
                bola.transform.localPosition = new Vector3(telapak.transform.localPosition.x + .15f, telapak.transform.localPosition.y - .2f, telapak.transform.localPosition.z + .6f);
                bola.GetComponent<Renderer>().material.color = Color.blue;
                tertangkap = true;
            }
            else if (tertangkap)
            {
                bola.transform.SetParent(null);
                bola.transform.localPosition = posisiBola;
                bola.GetComponent<Renderer>().material.color = Color.red;
                tertangkap = false;
            }
        }
    }
}

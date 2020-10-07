using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VRGaze : MonoBehaviour
{
    public Image imgGaze;
    public Text imgText;
    public float totalTime = 2;
    bool gvrStatus;
    float gvrTimer;

    public int distanceOfRay = 10;
    private RaycastHit _hit;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (gvrStatus)
        {
            gvrTimer += Time.deltaTime;
            imgGaze.fillAmount = gvrTimer / totalTime;

            if (imgGaze.fillAmount == 1)
            {
                Ray ray = Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0f));

                if (Physics.Raycast(ray, out _hit, distanceOfRay))
                {
                    switch (_hit.transform.tag)
                    {
                        case "hitam":
                            imgText.text = "Ini kubu hitam";
                            imgText.gameObject.SetActive(true);
                            break;
                        case "putih":
                            imgText.text = "Ini kubu putih";
                            imgText.gameObject.SetActive(true);
                            break;
                        case "merah":
                            imgText.text = "Ini kubu merah";
                            imgText.gameObject.SetActive(true);
                            break;
                    }
                }

            }

        }

    }

    public void GVROn()
    {
        gvrStatus = true;
    }

    public void GVROff()
    {
        gvrStatus = false;
        gvrTimer = 0;
        imgGaze.fillAmount = 0;
        imgText.gameObject.SetActive(false);
    }
}

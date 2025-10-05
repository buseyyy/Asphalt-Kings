using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCamera : MonoBehaviour
{
    [Header("Camera Count")]
    [SerializeField] Camera[] camerasCount;

    [Header("Current Camera")]
    [SerializeField] int currentCameraIndex = 0;


    void Start()
    {
        // Ilk kamerayi etkinlestir, digerlerini devre disi birak
        for (int i = 0; i < camerasCount.Length; i++)
        {
            camerasCount[i].gameObject.SetActive(i == currentCameraIndex);
        }
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            SwitchCamera();
        }
    }

    void SwitchCamera()
    {
        // Mevcut kamerayi devre disi birak
        camerasCount[currentCameraIndex].gameObject.SetActive(false);

        // Bir sonraki kameraya gec
        currentCameraIndex = (currentCameraIndex + 1) % camerasCount.Length;

        // Yeni kamerayi etkinlestir
        camerasCount[currentCameraIndex].gameObject.SetActive(true);
    }
}

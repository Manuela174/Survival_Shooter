using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class CameraFollow: MonoBehaviour
{
    public Transform meta; //Položaj kojega kamera slijedi
    public float filtriranje = 5f; //Brzina kojom kamera slijedi
    Vector3 pomak; //Početno odmicanje od meta

    void Start()
    {
        //Izračun početnog pomaka
        pomak = transform.position -meta.position;
    }

    void FixedUpdate()
    {//kreiranje pozicije kamere cilja na temelju meta do pomak
        Vector3 targetCamPos = meta.position + pomak;

        //Glatko procijeniti položaj kamere prema trenutnom položaju i meta položaju
        transform.position = Vector3.Lerp(transform.position, targetCamPos, filtriranje * Time.deltaTime);
    }
}
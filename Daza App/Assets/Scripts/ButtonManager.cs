using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonManager : MonoBehaviour
{
    public GameObject camera;


    public void Volver()
    {
        camera.transform.position = new Vector3(0f, 0f, -10f);
    }
    public void Propuestas()
    {
        camera.transform.position = new Vector3(12f, 5f, -10f);
    }
    public void Familia()
    {
        camera.transform.position = new Vector3(-12f, 5f, -10f);
    }
    public void Estudio()
    {
        camera.transform.position = new Vector3(12f, -5f, -10f);
    }
    public void Experiencia()
    {
        camera.transform.position = new Vector3(-12f, -5f, -10f);
    }
}

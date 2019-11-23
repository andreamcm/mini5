// Universidad del Valle de Guatemala
// Michelle Bloomfield, 16803
// Andrea Cordon, 16076
// fuzzy.cs

using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class fuzzy : MonoBehaviour
{
    // Variables iniciales, muestran los objetos a utilizar
    public GameObject pelota;
    public GameObject persona;
    public float smoothTime;
    public float convertedTime;
    public float smooth;

    // Funcion que determina que tan lejos o cerca esta la pelota
    float positionX(GameObject pelota, GameObject persona)
    {
        float pospelota = GameObject.FindGameObjectWithTag("pelota").transform.position.x;
        float pospersona = GameObject.FindGameObjectWithTag("persona").transform.position.x;
        float posx = Mathf.Abs(pospelota - pospersona);
        float posxf = (posx) / 21f;
        return posxf;
    }

    float positionY(GameObject pelota, GameObject persona)
    {
        float pospelota = GameObject.FindGameObjectWithTag("pelota").transform.position.z;
        float pospersona = GameObject.FindGameObjectWithTag("persona").transform.position.z;
        float posy = Mathf.Abs(pospelota - pospersona);
        return (posy) / 8f;
    }

    // Funcion que determina la rotacion de la persona
    float angles(GameObject persona)
    {
        float angle1 = pelota.transform.rotation.eulerAngles.y;
        angle1 = 0;
        return angle1;
    }

    // Funciones que determinan las variables linguisticas:
    // De distancia
    string distanceling(float posx, float posy)
    {
        float m = Mathf.Abs(posx);
        Debug.Log("distanceling: ");
        Debug.Log(m);
        string distancia = "";
        // La pelota esta cerca
        if (m > 0 && m < 0.4)
        {
            distancia = "cerca";
        };

        // La pelota esta a medio camino
        if (m >= 0.4 && m < 0.7)
        {
            distancia = "medio";
        };

        // La pelota esta lejos
        if (m > 0.7)
        {
            distancia = "lejos";
        };

        return distancia;
    }

    // De angulo
    string angleling(GameObject pelota)
    {
        //float angle = angle1;
        float angle1 = pelota.transform.position.x;
        float angle2 = pelota.transform.position.z;
        string rotangle = "";
        // La persona apunta hacia el norte
        if (angle1 >= 0f && angle2 < 12f)
        {
            rotangle = "norte";
        };

        // La persona apunta hacia el este
        if (angle1 >= 20f && angle2 < 0f)
        {
            rotangle = "este";
        };

        // La persona apunta hacia el sur
        if (angle1 >= 0 && angle2 > 12f)
        {
            rotangle = "sur";
        };
        // La persona apunta hacia el oeste
        if (angle1 <= 10f && angle2 < 27.0f)
        {
            rotangle = "oeste";
        };
        return rotangle;
    }



    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float posiX = positionX(pelota, persona);
        Debug.Log(posiX);
        float posiY = positionY(pelota, persona);
        Debug.Log(posiY);
        float angli = angles(pelota);
        Debug.Log(angli);
        string distancemine = distanceling(posiX, posiY);
        Debug.Log(distancemine);
        string anglemine = angleling(pelota);
        Debug.Log(anglemine);
        string respuesta = "";
        float velocidad = 0.5f;
        float angle = 0;
        // Clausulas de Horn
        // Si esta cerca, a medias o lejos y la pelota esta al norte, gire 0 grados y muevase 5.25 en x y 2 en y a la velocidad correspondiente
        if (distancemine == "cerca" && anglemine == "norte")
        {
            respuesta = "Moverse 5.25 en X y 2 en Y a 0.5f";
            velocidad = 0.5f;
            angle = 0;
            
        }
        if (distancemine == "medio" && anglemine == "norte")
        {
            respuesta = "Moverse 10.50 en X y 4 en Y a 0.7f";
            velocidad = 0.7f;
            angle = 0;
            //persona.transform.Translate(Vector3.forward * Time.deltaTime * velocidad);
        }
        if (distancemine == "lejos" && anglemine == "norte")
        {
            respuesta = "Moverse 21 en X y 6 en Y a 1f";
            velocidad = 1f;
            angle = 0;
            //persona.transform.Translate(Vector3.forward * Time.deltaTime * velocidad);
        }

        // Si esta cerca, a medias o lejos y la pelota esta al este, gire 90 grados y muevase 10.5 en x y 4 en y a la velocidad correspondiente
        if (distancemine == "cerca" && anglemine == "este")
        {
            respuesta = "Moverse 5.25 en X y 2 en Y a 0.5f";
            velocidad = 0.5f;
            angle = 90;
            //persona.transform.Translate(Vector3.forward * Time.deltaTime * velocidad);
        }
        if (distancemine == "medio" && anglemine == "este")
        {
            respuesta = "Moverse 10.50 en X y 4 en Y a 0.7f";
            velocidad = 0.7f;
            angle = 90;
            //persona.transform.Translate(Vector3.forward * Time.deltaTime * velocidad);
        }
        if (distancemine == "lejos" && anglemine == "este")
        {
            respuesta = "Moverse 21 en X y 6 en Y a 1f";
            velocidad = 1f;
            angle = 90;
            //persona.transform.Translate(Vector3.forward * Time.deltaTime * velocidad);
        }

        // Si esta cerca, a medias o lejos y la pelota esta al oeste, gire 270 grados y muevase 15.75 en x y 6 en y a la velocidad correspondiente
        if (distancemine == "cerca" && anglemine == "oeste")
        {
            respuesta = "Moverse 5.25 en X y 2 en Y a 0.5f";
            velocidad = 0.5f;
            angle = 270;
            //persona.transform.Translate(Vector3.forward * Time.deltaTime * velocidad);
        }
        if (distancemine == "medio" && anglemine == "oeste")
        {
            respuesta = "Moverse 10.50 en X y 4 en Y a 0.7f";
            velocidad = 0.7f;
            angle = 270;
            //persona.transform.Translate(Vector3.forward * Time.deltaTime * velocidad);
        }
        if (distancemine == "lejos" && anglemine == "oeste")
        {
            respuesta = "Moverse 21 en X y 6 en Y a 1f";
            velocidad = 1f;
            angle = 270;
           // persona.transform.Translate(Vector3.forward * Time.deltaTime * velocidad);
        }

        // Si esta cerca, a medias o lejos y la pelota esta al sur, gire 180 grados y muevase 21 en x y 8 en y a la velocidad correspondiente
        if (distancemine == "cerca" && anglemine == "sur")
        {
            respuesta = "Moverse 5.25 en X y 2 en Y a 0.5f";
            velocidad = 0.5f;
            angle = 180;
            //persona.transform.Translate(Vector3.forward * Time.deltaTime * velocidad);
        }
        if (distancemine == "medio" && anglemine == "sur")
        {
            respuesta = "Moverse 10.50 en X y 4 en Y a 0.7f";
            velocidad = 0.7f;
            angle = 180;
            //persona.transform.Translate(Vector3.forward * Time.deltaTime * velocidad);
        }
        if (distancemine == "lejos" && anglemine == "sur")
        {
            respuesta = "Moverse 21 en X y 6 en Y a 1f";
            velocidad = 1f;
            angle = 180;
            //persona.transform.Translate(Vector3.forward * Time.deltaTime * velocidad);
        }

        Debug.Log(respuesta);

        smoothTime = 0.5f;
        convertedTime = 200f;
        smooth = Time.deltaTime * smoothTime * convertedTime;
        Vector3 angleofrotation = new Vector3(0f, angle, 0f);
        persona.transform.Translate(Vector3.forward * Time.deltaTime * velocidad);
        persona.transform.Rotate(angleofrotation * smooth);
    }

}

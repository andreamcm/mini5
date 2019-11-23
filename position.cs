// Universidad del Valle de Guatemala
// Michelle Bloomfield, 16803
// Andrea Cordón, 16076
// position.cs

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class position : MonoBehaviour
{
    public GameObject objeto;


    // Start is called before the first frame update
    void Start()
    {
        // Variables para indicar la posición en X y Y de los objetos
        float x = Random.Range(5f, 27.5f); // 21
        float y = objeto.transform.position.y;
        float z = Random.Range(8f,16f); // 8
        float a = Random.Range(0f, 359f);
        Debug.Log(a);
        //Debug.Log(x);
        Vector3 position2 = new Vector3(x, y, z);
        Quaternion rotation2 = new Quaternion(0f, a, 0f, 0f);
        objeto.transform.position = position2;
        objeto.transform.rotation = rotation2;
    }

    // Update is called once per frame
    void Update()
    {

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
	public GameObject player; //zmienna w której przechowujemy informacje o jaki obiekt nam chodzi
    Vector3 offset; //zmienna która przechowuje jakies koordynaty w osiach xyz
	// Start is called before the first frame update
	void Start()
    {
        offset = transform.position - player.transform.position; //obliczamy odstep pomiedzy kamera a graczem
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = offset + player.transform.position; ;
        //obliczamy pozycje kamery za pomoca pobrania aktualnej pozycji gracza w przestrzeni
        // dodajac do tego za kazdym razem (co klatke) offset tj. odstêp
    }
}

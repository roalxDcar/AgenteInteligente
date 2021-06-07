using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
	public Transform Player;
	// Velocidad de Translación
	public float velocidad;
	// Velocidad de Giro
	public float velocidadGiro;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.UpArrow))
        {
        	Player.Translate(Vector3.forward * velocidad);
        }
        if(Input.GetKey(KeyCode.DownArrow))
        {
        	Player.Translate(Vector3.back * velocidad);
        }

        if(Input.GetKey(KeyCode.LeftArrow))
        {
        	Player.Rotate(Vector3.down * velocidadGiro);
        }
        if(Input.GetKey(KeyCode.RightArrow))
        {
        	Player.Rotate(Vector3.up * velocidadGiro);
        }
    }
}

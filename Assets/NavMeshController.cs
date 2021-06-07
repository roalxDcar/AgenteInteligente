using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// Apliación de Inteligenecia Artifial
using UnityEngine.AI;

public class NavMeshController : MonoBehaviour
{
	public Transform objetivo;
	private NavMeshAgent agente;
    // Se llama al inicio antes de la primera actualización del cuadro
    void Start()
    {
    	// Instanacia de agente
        agente = GetComponent<NavMeshAgent>();
        // instanciar componente para el movimiento por teclado
    }

    // La actualización se llama una vez por fotograma
    void Update()
    {
    	//Nuestro agente tendra como destino a objetivo(esfera)
        agente.destination = objetivo.position;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StreeringBehavior : MonoBehaviour
{
    public Transform target;
    public float maxSpeed = 5f; // Velocidad máxima del objeto
    public float slowingDistance = 5f; // Distancia a partir de la cual el objeto comenzará a desacelerar
    public float stoppingDistance = 1f; // Distancia a partir de la cual el objeto se detendrá
    [SerializeField] float maxSpeedRotation = 5f;

    public void Arrive()
    {
        // Calcula la dirección hacia el objetivo
        Vector3 targetDirection = target.position - transform.position;

        // Calcula la distancia al objetivo
        float distance = targetDirection.magnitude;

        // Calcula la velocidad deseada
        float desiredSpeed = maxSpeed;

        // Si estamos dentro de la distancia de frenado, ajusta la velocidad
        if (distance < slowingDistance)
        {
            desiredSpeed = maxSpeed * (distance / slowingDistance);
        }

        // Si estamos dentro de la distancia de parada, detén completamente
        if (distance < stoppingDistance)
        {
            desiredSpeed = 0f;
        }
        Look();
        transform.position += transform.forward * Time.deltaTime * desiredSpeed;
    }

    public void Look()
    {
        Vector3 targetDirection = target.position - transform.position;
        // Calcula la fuerza de dirección hacia la velocidad deseada
        transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.LookRotation(targetDirection.normalized), Time.deltaTime * maxSpeedRotation);
    }

    
}

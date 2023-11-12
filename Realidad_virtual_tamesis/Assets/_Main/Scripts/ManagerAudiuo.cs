using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerAudio : MonoBehaviour
{
    [SerializeField] AudioSource audioReproducir;
    [SerializeField] AudioSource Inicio;
    [SerializeField] AudioClip tico;
    [SerializeField] AudioClip citri;
    [SerializeField] AudioClip Alis;
    [SerializeField] AudioClip nia;
    [SerializeField] AudioClip tina;
    bool pausa = false;
    bool yaReproducido = false; // Nueva variable

    private void OnTriggerEnter(Collider other)
    {
        if (!yaReproducido && other.CompareTag("Player")) // Agregar la condición para verificar si ya se reprodujo
        {
            print("Sí funciona");

            // Reproducir el clip de audio
            if (audioReproducir != null)
            {
                if (CompareTag("tico") && tico != null)
                {
                    audioReproducir.clip = tico;
                }
                else if (CompareTag("citri") && citri != null)
                {
                    audioReproducir.clip = citri;
                }
                else if (CompareTag("alis") && Alis != null)
                {
                    audioReproducir.clip = Alis;
                }
                else if (CompareTag("nia") && nia != null)
                {
                    audioReproducir.clip = nia;
                }
                else if (CompareTag("tina") && tina != null)
                {
                    audioReproducir.clip = tina;
                }
                else if (CompareTag("pause"))
                {
                    audioReproducir.Stop();
                }

                audioReproducir.Play();
                Inicio.Stop();
                pausa = true;
                yaReproducido = true; // Marcar como reproducido
            }
        }
    }
}
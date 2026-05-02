using UnityEngine;
using UnityEngine.Video;

public class Enemigo : MonoBehaviour
{
    public string Nombre;
    public int Vida;
    public int danio;

    public void RecibirDanio(int cantidadDanio)
    {
        Vida -= cantidadDanio;

        Debug.Log(Nombre + " recibió " + cantidadDanio + " de daño.");
        Debug.Log("Vida actual de " + Nombre + ": " + Vida);

        if (Vida <= 0)
        {
            Morir();
        }
    }

    public int ObtenerDanio() {
        return danio;
    }

    public int ObtenerVida() {
        return Vida;
    }

    public string ObtenerNombre() {
        return Nombre;
    }

    public bool EstaVivo() {
        if (Vida > 0) {
            return true;
        }
        else {
            return false;
        }
    }

    void Morir() {
        Destroy(gameObject); // PLOOOOOOOOOOOOOOOOWJHDVWKJSBBQLEKVBNWLKE
    }
}
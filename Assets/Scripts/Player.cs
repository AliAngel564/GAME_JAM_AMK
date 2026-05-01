using UnityEngine;

public class Player : MonoBehaviour
{
    public int vidaJugador = 100;

    public void TomarDaño(int damage)
    {
        vidaJugador -= damage;
    }

    public void CurarJugador(int cantCuracion)
    {
        vidaJugador += cantCuracion;
    }
}

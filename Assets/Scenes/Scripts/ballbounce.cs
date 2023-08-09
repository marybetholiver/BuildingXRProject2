
using UnityEngine;

public class ballbounce: MonoBehaviour
{
    public AudioSource boink;

    void OnCollisionEnter (Collision collision)
    {
        boink.Play();
    }
}

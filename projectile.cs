using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float speed = 10f; // Snelheid van het projectiel
    public float lifeTime = 2f; // Levensduur van het projectiel

    void Start()
    {
        // Vernietig het projectiel na een bepaalde tijd
        Destroy(gameObject, lifeTime);
    }

    void Update()
    {
        // Beweeg het projectiel naar voren
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }

    void OnCollisionEnter(Collision collision)
    {
        // Vernietig het projectiel bij botsing
        Destroy(gameObject);
    }
}

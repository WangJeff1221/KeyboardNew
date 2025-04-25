using UnityEngine;

public class BulletController : MonoBehaviour
{
    public float speed = 10f;  
    public AudioClip explosionSound;   

    void Start()
    {
        Destroy(gameObject, 5f);
    }

    void Update()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime);
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Enemy"))
        {
            GameManager.instance.AddScore(1);

            if (explosionSound != null)
            {
                AudioSource.PlayClipAtPoint(explosionSound, transform.position);
            }

            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }
}

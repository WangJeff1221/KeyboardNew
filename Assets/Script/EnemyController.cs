using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float speed = 3f;                

    void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);

        if (transform.position.x < -10f)
        {
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            GameManager.instance.TakeDamage(1);

            Destroy(gameObject);
        }
    }
}

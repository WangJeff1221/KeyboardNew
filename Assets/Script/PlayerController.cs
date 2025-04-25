using UnityEngine;

/// <summary>
/// ??????????????
/// </summary>
public class PlayerController : MonoBehaviour
{
    public float speed = 5f;                    
    public GameObject bulletPrefab;            
    public Transform bulletSpawn;              
    public AudioClip shootSound;                

    private Rigidbody2D rb;
    private AudioSource audioSource;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");
        Vector2 movement = new Vector2(moveX, moveY) * speed;
        rb.linearVelocity = movement;
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        if (bulletPrefab != null && bulletSpawn != null)
        {
            Instantiate(bulletPrefab, bulletSpawn.position, Quaternion.identity);
            if (audioSource != null && shootSound != null)
            {
                audioSource.PlayOneShot(shootSound);
            }
        }
    }
}

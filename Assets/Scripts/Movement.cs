using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public GameObject bulletPrefab;
    public Transform shootingPoint;
    public float shotgunSpreadAngle = 15f;
    public float bulletSpeed = 10f;

    private Vector2 moveDirection;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        HandleMovement();
        HandleShooting();
        RotatePlayerToMouse();
    }

    void HandleMovement()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        moveDirection = new Vector2(horizontal, vertical).normalized;
        rb.linearVelocity = moveDirection * moveSpeed;
    }

    void HandleShooting()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Shoot();
        }
        if (Input.GetMouseButtonDown(1))
        {
            ShootShotgun();
        }
    }

    void Shoot()
    {
        GameObject bullet = Instantiate(bulletPrefab, shootingPoint.position, Quaternion.identity);
        Vector2 bulletDirection = (Camera.main.ScreenToWorldPoint(Input.mousePosition) - shootingPoint.position).normalized;
        bullet.GetComponent<Rigidbody2D>().linearVelocity = bulletDirection * bulletSpeed;
    }

    void ShootShotgun()
    {
        for (int i = -1; i <= 1; i++)
        {
            GameObject bullet = Instantiate(bulletPrefab, shootingPoint.position, Quaternion.identity);
            Vector2 spreadDirection = (Camera.main.ScreenToWorldPoint(Input.mousePosition) - shootingPoint.position).normalized;
            float angleOffset = i * shotgunSpreadAngle;
            Vector2 rotatedDirection = RotateVector(spreadDirection, angleOffset);
            bullet.GetComponent<Rigidbody2D>().linearVelocity = rotatedDirection * bulletSpeed;
        }
    }

    Vector2 RotateVector(Vector2 vector, float angle)
    {
        float radianAngle = angle * Mathf.Deg2Rad;
        float cos = Mathf.Cos(radianAngle);
        float sin = Mathf.Sin(radianAngle);
        float x = vector.x * cos - vector.y * sin;
        float y = vector.x * sin + vector.y * cos;
        return new Vector2(x, y);
    }

    void RotatePlayerToMouse()
    {
        Vector2 directionToMouse = (Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position).normalized;
        float angle = Mathf.Atan2(directionToMouse.y, directionToMouse.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle));
    }
}

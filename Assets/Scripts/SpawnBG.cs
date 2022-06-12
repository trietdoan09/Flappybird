using UnityEngine;

public class SpawnBG : MonoBehaviour
{
    private Rigidbody2D rd;
    private BoxCollider2D box;
    private float width;
    private float speed = -3f;

    private void Start()
    {
        box = GetComponent<BoxCollider2D>();
        rd = GetComponent<Rigidbody2D>();
        width = box.size.x*3/4f;
        rd.velocity = new Vector3(speed, 0);
    }

    private void Update()
    {
        if (transform.position.x < -width)
        {
            Reposition();
        }
    }

    private void Reposition()
    {
        Vector3 vector3 = new Vector3(width * 2.5f, 0);
        transform.position = (Vector3)transform.position + vector3;
    }


}

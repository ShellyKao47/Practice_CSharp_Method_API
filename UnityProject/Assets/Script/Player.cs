
using UnityEngine;

public class Player : MonoBehaviour
{

    [Header("移動速度"), Range(0, 150)]
    public float speed = 10.5f;
    public SpriteRenderer spr;

    private Rigidbody2D rig;
    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        GetHorizontal();
        Move();
        if (Input.GetAxisRaw("Horizontal") >= 0)
        {
            spr.flipX = false;
        }
        else
        {
            spr.flipX = true;
        }
    }

    public float h;
    private void GetHorizontal()
    {
        // 水平
        h = Input.GetAxis("Horizontal");

    }
    private void Move()
    {
        // 剛體.加速度 = 二維(水平 * 速度，原本加速度的 Y)
        rig.velocity = new Vector2(h * speed, rig.velocity.y);
    }
}

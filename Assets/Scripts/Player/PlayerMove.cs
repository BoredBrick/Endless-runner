using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float moveSpeed = 3;
    public float sideSpeed = 4;
    public float jumpForce = 10;
    public Animator animator;


    private void Awake()
    {
        animator = GetComponentInChildren<Animator>();
    }
    void Update()
    {
        transform.Translate(moveSpeed * Time.deltaTime * Vector3.forward);

        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            if (gameObject.transform.position.x > LevelBoundary.leftBoundary)
            {
                transform.Translate(moveSpeed * Time.deltaTime * Vector3.left);
            }
        }

        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            if (gameObject.transform.position.x < LevelBoundary.rightBoundary)
            {
                transform.Translate(moveSpeed * Time.deltaTime * -1f * Vector3.left);
            }
        }
    }

    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.Space) || Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
        {
            if (gameObject.transform.position.y == 1.25)
            {
                animator.SetTrigger("jump");
                gameObject.GetComponent<Rigidbody>().AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
                //animator.ResetTrigger("run");

            }
        }
    }
}

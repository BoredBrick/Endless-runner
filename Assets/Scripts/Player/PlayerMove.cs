using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float moveSpeed = 3;
    public float sideSpeed = 4;

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
}

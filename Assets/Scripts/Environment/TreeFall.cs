using UnityEngine;

public class TreeFall : MonoBehaviour
{
    public GameObject Tree;
    private bool falling = false;
    public bool rightSideFall;
    private Quaternion finalRotationFallLeft = Quaternion.Euler(-94.31f, -85.798f, 170.879f);
    private Quaternion finalRotationFallRight = Quaternion.Euler(88.486f, 58.308f, -26.807f);
    private readonly float rotationSpeed = 1.5f;
    private void OnTriggerEnter(Collider obstacle)
    {
        if (obstacle.CompareTag("Player"))
        {
            if (Random.value <= 0.5)
            {
                falling = true;
            }
        }
    }

    private void Update()
    {
        if (falling)
        {
            Quaternion finalRotation = rightSideFall ? finalRotationFallRight : finalRotationFallLeft;
            Tree.transform.rotation = Quaternion.Slerp(Tree.transform.rotation, finalRotation, rotationSpeed * Time.deltaTime);
        }
    }
}

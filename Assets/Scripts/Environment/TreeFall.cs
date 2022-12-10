using UnityEngine;

public class TreeFall : MonoBehaviour
{
    public GameObject Tree;
    private bool falling = false;
    private Quaternion finalRotation = Quaternion.Euler(-94.31f, -85.798f, 170.879f);
    public float rotationSpeed = 1.5f;
    private void OnTriggerEnter(Collider obstacle)
    {
        if (obstacle.CompareTag("Player"))
        {
            falling = true;
        }
    }

    private void Update()
    {
        if (falling)
        {
            Tree.transform.rotation = Quaternion.Slerp(Tree.transform.rotation, finalRotation, rotationSpeed * Time.deltaTime);
        }
    }
}

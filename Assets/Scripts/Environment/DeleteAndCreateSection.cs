using UnityEngine;

public class DeleteAndCreateSection : MonoBehaviour
{
    private GenerateSection generator;
    private void Start()
    {
        generator = ScriptableObject.CreateInstance<GenerateSection>();
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Enter");
        if (other.CompareTag("Player"))
        {
            Vector3 parentPosition = transform.parent.position;
            parentPosition.z += 100f;
            Instantiate(generator.Generate(), parentPosition, Quaternion.identity);
            Destroy(transform.parent.gameObject);
        }
    }
}

using UnityEngine;

public class GenerateSection : ScriptableObject
{
    public const int numOfSections = 3;
    public GameObject[] sections = new GameObject[numOfSections];
    public void Awake()
    {
        for (int i = 0; i < numOfSections; i++)
        {
            sections[i] = Resources.Load("Prefabs/Sections/Section" + (i + 1)) as GameObject;
        }
    }
    public GameObject Generate()
    {
        return sections[Random.Range(0, numOfSections)];
    }
}

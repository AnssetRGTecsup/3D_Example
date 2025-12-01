using UnityEngine;

public class FlockingManager : MonoBehaviour
{
    [SerializeField] private GameObject objectPrefab;
    [SerializeField] private Transform objectTransform;
    [SerializeField] private int quantityPrefabs;
    [SerializeField, Range (1,5)] private float distanceMax;

    private GameObject[] instances;

    private void Start()
    {
        instances = new GameObject[quantityPrefabs];

        for (int i = 0; i < quantityPrefabs; i++)
        {
            Vector3 randomPos = new Vector3(Random.Range(-1.0f, 1.0f), Random.Range(-1.0f, 1.0f), Random.Range(-1.0f, 1.0f));
            randomPos *= distanceMax;
            randomPos += objectTransform.position;

            Instantiate(objectPrefab, randomPos, Quaternion.identity, objectTransform);
        }
    }
}

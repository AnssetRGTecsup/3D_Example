using System;
using UnityEngine;

using Random = UnityEngine.Random;

public class FlockingManager : MonoBehaviour
{
    [SerializeField] private FlockController objectPrefab;
    [SerializeField] private Transform objectTransform;
    [SerializeField] private int quantityPrefabs;
    [SerializeField, Range (1,5)] private float distanceMax;
    [SerializeField] private MinMaxRange<float> speedRange;

    private FlockController[] instances;

    private void Start()
    {
        instances = new FlockController[quantityPrefabs];

        for (int i = 0; i < quantityPrefabs; i++)
        {
            Vector3 randomPos = new Vector3(Random.Range(-1.0f, 1.0f), Random.Range(-1.0f, 1.0f), Random.Range(-1.0f, 1.0f));
            randomPos = randomPos * distanceMax + objectTransform.position;

            instances[i] =  Instantiate(objectPrefab, randomPos, Quaternion.identity, objectTransform);

            instances[i].SetUpController(Random.Range(speedRange.min, speedRange.max), this);
        }
    }
}

[Serializable]
public struct MinMaxRange<T> where T : struct
{
    public T min;
    public T max;
}
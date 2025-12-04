using UnityEngine;

public class FlockController : MonoBehaviour
{
    [SerializeField] private float currentSpeed;

    private FlockingManager _manager;

    private void Update()
    {
        transform.Translate(0,0, currentSpeed *  Time.deltaTime);
    }

    public void SetUpController(float newSpeed, FlockingManager managerReference)
    {
        currentSpeed = newSpeed;
        _manager = managerReference;
    }
}

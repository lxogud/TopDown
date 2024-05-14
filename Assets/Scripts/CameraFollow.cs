using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField]private GameObject Player;
    private Transform mainCamera;

    private void Start()
    {
        mainCamera = Camera.main.transform;
    }

    private void LateUpdate()
    {
        if (Player != null && mainCamera != null)
        {
            Vector3 newPosition = new Vector3(Player.transform.position.x, Player.transform.position.y, mainCamera.position.z);
            mainCamera.position = newPosition;
        }
    }
}

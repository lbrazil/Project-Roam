using UnityEngine;

public class CameraController1 : MonoBehaviour {

    [SerializeField] Transform PlayerTransform;
    [SerializeField] Transform Enemy;

    public Vector3 _cameraOffset;

    [Range(0.01f, 1.0f)]
    public float SmoothFactor = 0.5f;

    public bool LookAtPlayer = false;

    public bool RotateAroundPlayer = true;

    public float RotationsSpeed = 5.0f;

    [Range(0.01f, 100.0f)]
    public float extraoffset = 0.5f;
    [Range(0.01f, 100.0f)]
    public float ZoomValue = 0.5f;

    void Start()
    {
        //_cameraOffset = transform.position - PlayerTransform.position;
    }

    void LateUpdate()
    {
        if (RotateAroundPlayer)
        {
           //Quaternion camTurnAngle = Quaternion.AngleAxis(Input.GetAxis("Mouse X") * RotationsSpeed, Vector3.up);

            //_cameraOffset = camTurnAngle * _cameraOffset;
        }
        Camera.main.fieldOfView = (Vector3.Distance(PlayerTransform.position, Enemy.position) * ZoomValue) + extraoffset;
        Vector3 newPos = PlayerTransform.position + _cameraOffset;

        transform.position = Vector3.Slerp(transform.position, newPos, SmoothFactor);

        if (LookAtPlayer || RotateAroundPlayer)
            transform.LookAt(PlayerTransform);
    }
}

using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;  // Ҫ�����Ŀ������
    public float smoothSpeed = 0.125f;  // ����ƶ���ƽ����
    public Vector3 offset = new Vector3(0f, 0f, -1f);  // ��������Ŀ�������ƫ����

    void LateUpdate()
    {
        if (target != null)
        {
            Vector3 desiredPosition = target.position + offset;
            Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
            transform.position = smoothedPosition;
        }
    }
}
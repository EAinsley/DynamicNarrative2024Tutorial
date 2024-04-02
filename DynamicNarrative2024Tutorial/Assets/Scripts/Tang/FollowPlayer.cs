using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform player; // ��Ҷ����Transform���
    public float followRadius = 5f; // ��ɫ��ʼ������ҵİ뾶
    public float followSpeed = 2f; // ��ɫ������ҵ��ٶ�

    private bool isFollowing = false; // �Ƿ����ڸ������

    void Update()
    {
        // �����ɫ�����֮��ľ���
        float distanceToPlayer = Vector3.Distance(transform.position, player.position);

        // �����ҽ����˸��淶Χ����ʼ�������
        if (distanceToPlayer <= followRadius)
        {
            isFollowing = true;
        }
        else
        {
            isFollowing = false;
        }

        // ������ڸ�����ң����½�ɫλ��
        if (isFollowing)
        {
            // �����ɫ������ƶ��ķ���
            Vector3 direction = (player.position - transform.position).normalized;

            // ����ɫ���ŷ���������ƶ�
            transform.position += direction * followSpeed * Time.deltaTime;
        }
    }

    void OnDrawGizmosSelected()
    {
        // ��Scene��ͼ�л���һ��Բ�Σ���ʾ���淶Χ
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, followRadius);
    }
}

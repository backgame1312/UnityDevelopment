using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoateCamera_20223413 : MonoBehaviour
{
    public float rotationSpeed = 100;
    
    //���ӿ��� Ȯ�ο� -> ������ 20223413 
    public GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        //��ũ��Ʈ �ޱ� -> ������ 20223413
        gameManager = FindObjectOfType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        //���ӿ����� �ƴϸ� �����δ� -> ������ 20223413
        if(!gameManager.GetGameOver())
        {
            float horizontalInput = Input.GetAxis("Horizontal");
            transform.Rotate(Vector3.up, horizontalInput * rotationSpeed * Time.deltaTime);
        }
        //���ӿ������ ī�޶� ���󺹱� ��Ű�� �������� ���ϵ��� �Ѵ� - > ������ 20223413
        else
        {
            transform.rotation = Quaternion.identity;
        }
    }
}
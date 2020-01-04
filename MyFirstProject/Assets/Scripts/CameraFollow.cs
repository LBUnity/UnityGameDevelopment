using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    private Transform m_pumpkinPos;
    private float m_zDistance = 7f;
    private float m_yDistance = 4f;

    private void Awake()
    {
        m_pumpkinPos = GameObject.Find("Pumpkin").transform;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 temp = transform.position;
        temp.y = m_pumpkinPos.position.y + m_yDistance;
        temp.z = m_pumpkinPos.position.z - m_zDistance;
        transform.position = temp;
    }
}

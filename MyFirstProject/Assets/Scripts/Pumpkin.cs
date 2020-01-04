using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pumpkin : MonoBehaviour
{
    public float MoveForce = 10f;
    private Rigidbody m_myBody;

    //called before start()
    private void Awake()
    {
        m_myBody = GetComponent<Rigidbody>();    
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Updated every 4-5th frame
    void FixedUpdate()
    {
        MovePumpkin();
    }

    void MovePumpkin()
    {
        float h = Input.GetAxis("Horizontal"); //changes when you press the left, right arrow keys
        float v = Input.GetAxis("Vertical"); //changes when you press the up, down arrow keys

        m_myBody.AddForce(new Vector3(h * MoveForce, 0f, v * MoveForce));
    }

    private void OnTriggerEnter(Collider _target)
    {
        if (_target.tag == "Golem" || _target.tag == "Gates")
        {
            Time.timeScale = 0;
        }
    }
}

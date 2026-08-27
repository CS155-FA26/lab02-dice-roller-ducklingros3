using UnityEngine;
using UnityEngine.InputSystem;

public class Roller : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Mouse.current.leftButton.isPressed)
        {
            Vector3 rotation = new Vector3(0f, 1f, 0f);
            this.transform.Rotate(rotation);
            Vector3 position = new Vector3(0f, 0.01f, 0f);


            this.transform.position += position; 
        } 
    }
}

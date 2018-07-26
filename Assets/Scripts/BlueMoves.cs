using UnityEngine;
using System.Collections;

public class BlueMoves : MonoBehaviour
{
    [SerializeField] private float speed = 10.0F;
    [SerializeField] private float rotationSpeed = 100.0F;

    void Update()
    {
    	KbMoving();
    }

    private void KbMoving()
    {
        float translation = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        float rotation = Input.GetAxis("Horizontal") * rotationSpeed * Time.deltaTime;
        transform.Translate(0, 0, translation);
        transform.Rotate(0, rotation, 0);
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public Vector2 mousePosition;
 
    void Update()
    {
        // Aquí guardas la posición del mouse en el mapa
        mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        // Aquí calculas cuánto hay que rotar para que el objeto mire al mouse
        float distanceToRotate = getAngle(transform.position, mousePosition);
            // Aplicas la rotación
        transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0, 0, distanceToRotate), 1);

        // Función que calcula cuánto necesitas rotar
        float getAngle (Vector2 position, Vector2 mousePosition) {
            float x = mousePosition.x - position.x;
            float y = mousePosition.y - position.y;

            return Mathf.Rad2Deg * Mathf.Atan2(y, x);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    public Transform cursor;
    public Transform arrow;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Confined;
        Cursor.visible = false;
    }

    void Update()
    {
        //float angle = Vector2.Angle(new Vector2(Screen.width/2, Screen.height/2), Input.mousePosition);
        Vector3 relative = transform.InverseTransformPoint(cursor.position);
        float angle = Mathf.Atan2(relative.x, relative.y) * Mathf.Rad2Deg;
        //Debug.Log(Screen.height/2 + " " + Screen.width/2);
        //Debug.Log(Input.mousePosition);
        Debug.Log(angle);

        cursor.position = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 1));
        arrow.transform.eulerAngles = new Vector3(0, 0, (-angle + 90));
    }
}

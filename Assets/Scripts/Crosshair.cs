using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crosshair : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start() {

        Cursor.visible = false;
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) {

            if (Cursor.visible == true) {
                Cursor.visible = false;
            }
            else if (Cursor.visible == false) {
                Cursor.visible = true;
            }

        }

        if (Cursor.visible == false) {

            transform.position = Input.mousePosition;
        }
        Debug.Log(Cursor.visible);
    }
}

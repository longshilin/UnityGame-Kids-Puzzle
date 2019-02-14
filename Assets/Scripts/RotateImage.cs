using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateImage : MonoBehaviour
{
    private void OnMouseDown()
    {
        if (!GameController.youWin)
            transform.Rotate(0f, 0f, 90f);
    }
}

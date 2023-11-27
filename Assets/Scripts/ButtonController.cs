using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonController : MonoBehaviour
{
    [SerializeField] private Color defaultColor;
    [SerializeField] private Color pressColor;

    [SerializeField] public KeyCode keyToPress;

    private SpriteRenderer spriteRenderer;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        if (Input.GetKeyUp(keyToPress))
        {
            spriteRenderer.color = defaultColor;
        }

        if (Input.GetKeyDown(keyToPress))
        {
            spriteRenderer.color = pressColor;
        }
    }
}

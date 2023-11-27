using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NodeObject : MonoBehaviour
{
    [SerializeField] private AudioClip sound;

    [SerializeField] private bool canBePress;

    [SerializeField] private KeyCode keyToPress;

    private bool isPress = false;

    private void Update()
    {
        if (Input.GetKeyDown(keyToPress))
        {
            if(canBePress)
            {
                GameManager.Instance.NoteHit();
                SoundManager.Instance.PlaySound(sound);
                isPress = true;
                gameObject.SetActive(false);
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Activator")
        {
            canBePress = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Activator" && !isPress)
        {
            canBePress = false;

            GameManager.Instance.NoteMiss();
        }
    }
}

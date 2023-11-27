using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    //[SerializeField] private AudioSource music;

    [SerializeField] private bool startPlaying;

    [SerializeField] private BeatScroller beatScroller;

    [SerializeField] private float currentScore;
    [SerializeField] private float scorePerNote;

    [SerializeField] private int currentMultiplier;
    [SerializeField] private int multiplierTracker;
    [SerializeField] private int[] multiplierThresholds;

    [SerializeField] private TextMeshProUGUI scoreText;
    [SerializeField] private TextMeshProUGUI multiText;



    public static GameManager Instance;

    private void Start()
    {
        Instance = this;

        scoreText.text = "SCORE: 0";
        currentMultiplier = 1;
    }

    private void Update()
    {
        if (!startPlaying)
        {
            if (Input.anyKeyDown)
            {
                startPlaying = true;
                beatScroller.isStart = true;

                //music.Play();
            }
        }
    }

    public void NoteHit()
    {
        if (currentMultiplier - 1 < multiplierThresholds.Length)
        {
            multiplierTracker++;

            if (multiplierThresholds[currentMultiplier - 1] <= multiplierTracker)
            {
                multiplierTracker = 0;
                currentMultiplier++;
            }
        }

        multiText.text = "COMBE: x" + currentMultiplier.ToString();

        currentScore += scorePerNote;
        scoreText.text = "SCORE: " + currentScore;
    }

    public void NoteMiss()
    {
        currentMultiplier = 1;
        multiplierTracker = 0;

        multiText.text = "COMBE: x" + currentMultiplier;
    }
}

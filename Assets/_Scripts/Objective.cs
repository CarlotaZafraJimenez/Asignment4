using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objective : MonoBehaviour
{
        public Sprite ObjectiveCompleteSprite;
        public GameObject LevelCompleteScreen;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        SpriteRenderer sr = GetComponent<SpriteRenderer>();
        sr.sprite = ObjectiveCompleteSprite;

        LevelCompleteScreen.SetActive(true);
    }

}

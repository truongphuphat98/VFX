using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImproveAttribute : MonoBehaviour
{
    [Header("Character Stats")]
    [SerializeField]
    private int maxHealth = 100;

    [ContextMenuItem("Choose Random DPS", "RandomizeDPS")]
    [SerializeField]
    [Range(1,10)]
    private int dmgPersecond = 3;

    [Header("Character Description")]
    [SerializeField]
    private string characterName;

    [SerializeField]
    [Multiline]
    private string characterDescription;

    private int currentHealth;

    [ContextMenu("TakeDamage")]
    public void TakeDamage()
    {
        currentHealth--;
    }

    private void RandomizeDPS()
    {
        dmgPersecond = UnityEngine.Random.Range(1, 10);
    }
}
